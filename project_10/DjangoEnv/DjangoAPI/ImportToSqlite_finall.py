import sqlite3
import csv
import os

# introduce spatialite
spatialite_path = './mod_spatialite-5.1.0-win-amd64'
os.environ['PATH'] = spatialite_path + ';' + os.environ['PATH']
# connect and active spatialite
conn = sqlite3.connect('db.sqlite3')
conn.enable_load_extension(True)
conn.load_extension("mod_spatialite")

cur = conn.cursor()

# drop All tables
cur.execute("SELECT name FROM sqlite_master WHERE type='table';")
tables = cur.fetchall()
for table in tables:
    cur.execute('DROP TABLE IF EXISTS ' + table[0])

# Create the companies table if it doesn't exist
cur.execute('''CREATE TABLE IF NOT EXISTS companies 
                (id INTEGER PRIMARY KEY, geom POINT NOT NULL, name TEXT NOT NULL UNIQUE, founder TEXT NOT NULL, country TEXT NOT NULL, contact_info TEXT)''')
cur.execute('''CREATE TABLE IF NOT EXISTS projects 
                (id INTEGER PRIMARY KEY, name TEXT NOT NULL UNIQUE, company_id INTEGER, FOREIGN KEY(company_id) REFERENCES companies(id) ON DELETE CASCADE)''')

with open('company.csv', 'r') as fin:
    # csv.DictReader uses the first line as column headings by default
    dr = csv.DictReader(fin)
    # Prepare the data for insertion
    to_db = [(f"POINT({float(i['Lat'])} {float(i['Long'])})", i['name'], i['Founder'], i['Country'], i['Contact Info']) for i in dr]
    # Insert the data into the database
    cur.executemany("INSERT INTO companies (geom, name, founder, country, contact_info) VALUES (GeomFromText(?, 4326), ?, ?, ?, ?)", to_db)

with open('project.csv', 'r') as fin:
    # csv.DictReader uses the first line as column headings by default
    dr = csv.DictReader(fin)
    # Prepare the data for insertion
    to_db = [(i['Name'], i['Company ID']) for i in dr]
    # Insert the data into the database
    cur.executemany("INSERT INTO projects (name, company_id) VALUES (?, ?)", to_db)

# Select all rows from the companies table
cur.execute("SELECT companies.id, ST_X(companies.geom), ST_Y(companies.geom), companies.name, companies.founder, companies.country, companies.contact_info, projects.name  FROM companies JOIN projects ON companies.id = projects.company_id")

# Fetch and print the results
rows = cur.fetchall()
for row in rows:
    print(row)
print()

# cur.execute("SELECT DISTINCT POINTType(geom) FROM companies;")

# cur.execute("select Distance(GeomFromText('POINT(0 0)',4326),GeomFromText('POINT(3 4)',4326));")
cur.execute('''SELECT
    id,
    ST_X(geom),
    ST_Y(geom),
    name,
    founder,
    country,
    contact_info,
    Distance(GeomFromText('POINT(37.791389 122.397222)', 4326), geom) AS distance
    FROM companies
    ORDER BY distance;
    ''')



# Fetch and print the results
rows = cur.fetchall()
for row in rows:
    print(row)


# Close the connection
conn.commit()
conn.close()