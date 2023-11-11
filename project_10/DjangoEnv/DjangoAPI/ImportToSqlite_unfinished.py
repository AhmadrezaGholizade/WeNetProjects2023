import sqlite3

conn = sqlite3.connect('db.sqlite3')
c = conn.cursor()

c.execute("SELECT name FROM sqlite_master WHERE type='table';")
tables = c.fetchall()

for table in tables:
    c.execute('DROP TABLE IF EXISTS ' + table[0])

# c.execute("""
#     CREATE TABLE companies (
#         id INTEGER PRIMARY KEY,
#         X REAL,
#         Y REAL,
#         name TEXT,
#         founder TEXT,
#         country TEXT,
#         contact_info TEXT
#     )
# """)
# c.execute("""
#     CREATE TABLE projects (
#         id INTEGER PRIMARY KEY,
#         name TEXT,
#         company_id INTEGER,
#         FOREIGN KEY(company_id) REFERENCES companies(id)
#     )
# """)

conn.commit()
conn.close()

# Create your models here.
class Architectural_Firm():
    def __init__(self, x, y, name, founder, country, projects, contact_info):
        self.x = x 
        self.y = y 
        self.name = name 
        self.founder = founder 
        self.country = country 
        self.projects = projects 
        self.contact_info = contact_info 

        conn = sqlite3.connect('db.sqlite3')
        c = conn.cursor()
        c.execute("INSERT INTO companies (X, Y, name, founder, country, contact_info) VALUES (?, ?, ?, ?, ?, ?)", (self.x, self.y,self.name, self.founder, self.country, self.contact_info))
        last_id = c.lastrowid
        for prj in projects:
            c.execute("INSERT INTO projects (name, company_id) VALUES (?, ?)", (prj, last_id))
        conn.commit()
        conn.close()
        del self


# Architectural_Firm(51.1, 35.5, "Gensler", "John Adams", "United States", ["San Francisco International Airport", "Viettel Group Headquarters"],  "product_librarians@gensler.com")
# Architectural_Firm(52.3, 34.3, "HDR", "H.H. Henningson", "Canada", ["Hidalgo County Courthouse", "Multnomah County Courthouse"], "(402) 399-1000")
# Architectural_Firm(53.2, 32.3, "Nikken Sekkei", "Tadao Kamei", "Japon", ["Osaka Library", "The Sumitomo Building"], "global@nikken.jp")
# Architectural_Firm(49.9, 35.7, "Sweco", "Gunnar Nordström", "Sweden", ["Aarhus Stadium", "Gamlestaden Travel Centre"], "+46 8 695 60 00")
     
