from django.http import HttpResponse, JsonResponse
import sqlite3
import os
from django.conf import settings 

BASE_DIR = settings.BASE_DIR

# Create your views here.
def get_nearest(request, x, y):
    print("HI-----------------------------")
    
    # Set the path for mod_spatialite
    spatialite_path = os.path.join(BASE_DIR, 'mod_spatialite-5.1.0-win-amd64')
    os.environ['PATH'] = spatialite_path + ';' + os.environ['PATH']
    
    # Connect and activate spatialite
    conn = sqlite3.connect(os.path.join(BASE_DIR, 'db.sqlite3'))
    conn.enable_load_extension(True)
    conn.load_extension("mod_spatialite")

    # Create a cursor
    cursor = conn.cursor()

    # Execute the spatial query
    # cursor.execute(f"SELECT id, ST_X(geom), ST_Y(geom), name, founder, country, contact_info FROM companies ORDER BY Distance(GeomFromText('POINT({x} {y})', 4326)), geom) LIMIT 1;")
    cursor.execute(f'''SELECT
    id,
    ST_X(geom),
    ST_Y(geom),
    name,
    founder,
    country,
    contact_info,
    Distance(GeomFromText('POINT({x} {y})', 4326), geom) AS distance
    FROM companies
    ORDER BY distance
    LIMIT 1;
    ''')
    
    # Fetch the single result
    rows = cursor.fetchone()
    print(rows)

    
    # Close the cursor and connection
    cursor.close()
    conn.close()

    # print(row)
    dict = {'ID': rows[0], 'latitude': rows[1], 'longitude': rows[2], 'name': rows[3], 'founder': rows[4], 'country': rows[5], 'contant_info': rows[6]}
    
    # Return the result in the HttpResponse
    return JsonResponse(dict)
