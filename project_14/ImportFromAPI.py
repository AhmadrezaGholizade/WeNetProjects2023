import requests
import sqlite3

api = 'https://production.dataviz.cnn.io/markets/index/DJII-USA,SP500-CME,COMP-USA/2023-11-21'

# headers based on the ones you observed in your browser
headers = {
    'User-Agent': 'Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Mobile Safari/537.36 Edg/119.0.0.0',
    'Accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7',
}



# Connect to the SQLite database
conn = sqlite3.connect('PriceHistory.db')
cursor = conn.cursor()

temp = True
while(temp):
    temp = False

    response = requests.get(api, headers=headers)

    # Check if the request was successful (status code 200)
    if response.status_code == 200:
        data = response.json()
        # print(data)

        prices = [i["current_price"] for i in data]

        # print(prices)

        # Inserting prices from json
        insert_prices_data_query = f'''
        INSERT INTO prices (price, stock_id)
        VALUES
            ({prices[0]}, 1),
            ({prices[1]}, 2),
            ({prices[2]}, 3);
        '''
        cursor.execute(insert_prices_data_query)
        conn.commit()
        conn.close()
    else:
        # If the request was not successful, print an error message
        print(f"Error: {response.status_code}")



