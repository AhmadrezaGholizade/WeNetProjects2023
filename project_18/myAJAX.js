// alert("Connected")

function get_image(event){
    // alert("Clicked")
    event.preventDefault();
    const formData = new FormData(event.target);
    if (formData.get('status') === ""){
        document.getElementById("Guide").innerHTML = 'Just Enter a Number. <div id = "warn"> Enter THE Code <div>';
    } else {
        document.getElementById("Guide").innerHTML = 'Just Enter a Number.';
        var image_container = document.getElementById('img');

        // var xhttp = new XMLHttpRequest();
        // xhttp.onreadystatechange = function() {
        //     if (this.readyState == 4 && this.status == 200) {
        image_container.innerHTML = "<img src=" + "'https://http.cat/" + formData.get('status') + ".jpg" + "' alt='response'>";
            // }
        // };
        // xhttp.open("GET","https://http.cat/" + formData.get('status'),true);
        // xhttp.send();
    }
}


  