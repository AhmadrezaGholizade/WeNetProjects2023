<%
        ' Function to calculate the distance between two points
        Function CalculateDistance(X1, Y1, X2, Y2)
            CalculateDistance = Sqr((X2 - X1)^2 + (Y2 - Y1)^2)
        End Function

        ' Retrieve the coordinates from the query string
        Dim X1, Y1, X2, Y2
        X1 = CDbl(Request.QueryString("X1"))
        Y1 = CDbl(Request.QueryString("Y1"))
        X2 = CDbl(Request.QueryString("X2"))
        Y2 = CDbl(Request.QueryString("Y2"))

        ' Call the function to calculate distance
        Dim distance
        distance = CalculateDistance(X1, Y1, X2, Y2)
%>


<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;700&display=swap" rel="stylesheet">
        <title>Distance Sheet</title>
        <link rel="icon" type="image/png" href="assets/icon/icn.png">
        <link rel="stylesheet" href="assets/css/distance_sheet.css">
    </head>
    <body>
        <div id="container">
            <h1>
                Distance: <%= FormatNumber(distance, 2) %>
                <img id="img" src="assets/icon/distance.png">
            </h1>
            <ul>
                <li> Point 1: (<%= X1 %>, <%= Y1 %>)</li>
                <li> Point 2: (<%= X2 %>, <%= Y2 %>)</li>
            </ul>
        </div>
    </body>
</html>
