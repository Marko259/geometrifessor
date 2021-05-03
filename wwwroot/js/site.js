// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function beregnC() {
    a = document.getElementById('a').value;
    b = document.getElementById('b').value;
    c = Math.sqrt((a * a) + (b * b));
    document.getElementById("cer").innerHTML = c;
    /* retter punkterne i svg'en så trekanten bliver flyttet*/
    document.getElementById("trekant").setAttribute("points", "0,0 0," + a * 20 + " " + b * 20 + "," + a * 20);
}

function beregnBen() {
    ab = document.getElementById("a").value;
    bb = document.getElementById("b").value;
    cb = Math.abs(ab);
    TPb = (bb/2);
    document.getElementById("cerBen").innerHTML = cb;
    document.getElementById("ligebenettrekant").setAttribute("points" , TPb + ",0 0," + ab * 20 + " " + bb * 20 + "," + ab * 20)
}
