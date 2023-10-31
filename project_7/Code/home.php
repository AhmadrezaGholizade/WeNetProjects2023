<!DOCTYPE html>
<html lang = "en">
<head>
    <meta charset = "UTF-8">
    <meta name = "viewport" content = "width = device-width, initial-scale = 1.0">
    <link rel = "icon" href = "img/memasik-logo.png" type = "image/png">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Comic+Neue:wght@700&display=swap" rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="home.css">
    <title>MEME</title>
</head>
<body>
    <div id = "form">
        <form method = "post">
            <div>
                <!-- the inputs are durable because of the php scripts -->
                <input type = "text" name = "Up" placeholder="First Text" value="<?php echo isset($_POST['Up']) ? $_POST['Up'] : '' ?>">
                <input type = "text" name = "Down" placeholder="Second Text" value="<?php echo isset($_POST['Down']) ? $_POST['Down'] : '' ?>">
                <select name="Image" required>
                    <option selected disabled value="">Select an option</option>
                    <option value="drake" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'drake') ? 'selected' : '' ?>>Drake</option>
                    <option value="buzz" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'buzz') ? 'selected' : '' ?>>Buzz Lightyear</option>
                    <option value="both" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'both') ? 'selected' : '' ?>>Both (girl)</option>
                    <option value="cheems" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'cheems') ? 'selected' : '' ?>>Cheems</option>
                    <option value="slap" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'slap') ? 'selected' : '' ?>>Will Smith Slap</option>
                    <option value="spiderman" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'spiderman') ? 'selected' : '' ?>>Spidermans</option>
                    <option value="michael-scott" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'michael-scott') ? 'selected' : '' ?>>Michael Scott</option>
                    <option value="harold" <?php echo (isset($_POST['Image']) && $_POST['Image'] == 'harold') ? 'selected' : '' ?>>Harold</option>
                </select>
                <input class="btn btn-primary" id = "sub" type = "submit" value = "GENERATE">
            </div>
        </form>
    <div>

    <?php
    // Making meme from form
    if ($_SERVER["REQUEST_METHOD"] == "POST") 
    {
        // Making meme if text boxes is full
        if ($_POST["Up"] != '' && $_POST["Down"] != '')
        {
            $url1 = 'https://api.memegen.link/images/';
            $image = $_POST["Image"];
            $up = $_POST["Up"];
            $down = $_POST["Down"];

            // URL Encoding
            $up = str_replace("-", "--" ,$up);
            $up = str_replace("-", "--", $up);
            $up = str_replace(" ", "-", $up);
            $up = str_replace("_", "__", $up);
            $up = str_replace("?", "~q", $up);
            $up = str_replace("%", "~p", $up);
            $up = str_replace("#", "~h", $up);
            $up = str_replace("/", "~s", $up);
            $up = str_replace('"', "''", $up);

            $down = str_replace("-", "--" ,$down);
            $down = str_replace("-", "--", $down);
            $down = str_replace(" ", "-", $down);
            $down = str_replace("_", "__", $down);
            $down = str_replace("?", "~q", $down);
            $down = str_replace("%", "~p", $down);
            $down = str_replace("#", "~h", $down);
            $down = str_replace("/", "~s", $down);
            $down = str_replace('"', "''", $down);
            
            $url2 = '.png?height=450&width=800';
            $finalUrl = $url1 . $image . '/' . $up . '/' . $down . $url2;
            echo '<img src="'. $finalUrl . '" alt="Description of image">';
            // echo $finalUrl;
        }
        else
        {
            // Giving hint if User didn't Complete The TextBoxes
            echo '<img src="https://api.memegen.link/images/jim/If-you-want-Meme/Complete-Text-boxes.png?height=450&width=800" alt="Description of image">';     
        }
    }
    ?>
    
    
</body>
</html>