// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function beregnC() {
    a = document.getElementById('a').value;
    b = document.getElementById('b').value;
    c = Math.sqrt((a * a) + (b * b));
    document.getElementById("cer").innerHTML = "C = " + c.toFixed(2);
    /* retter punkterne i svg'en så trekanten bliver flyttet*/
    document.getElementById("retvinklettrekant").setAttribute("points", "0,0 0," + a * 20 + " " + b * 20 + "," + a * 20);
    RetAreal = a * b / 2
    document.getElementById("Areal").innerHTML = "Areal = " + RetAreal;
}

function beregnBen() {
    ab = document.getElementById("vilkårlig-a").value;
    bb = document.getElementById("vilkårlig-b").value;
    hjd = Math.sqrt((ab * ab) - (bb / 2 * bb / 2));
    Areal = ab * hjd / 2;
    TPb = (bb / 2);
    document.getElementById("vilkårlig-cer").innerHTML = "Areal = " + Areal.toFixed(2);
    /* retter punkterne i svg'en så trekanten bliver flyttet*/
    document.getElementById("ligebenettrekant").setAttribute("points", TPb * 20 + ",0 0," + ab * 20 + " " + bb * 20 + "," + ab * 20);
}

function beregnSide() {
    as = document.getElementById('ligesidet-a').value;
    cs = Math.abs(as);
    TPS = (as / 2);
    aH = as * Math.sqrt(3) / 2;
    AreLS = aH * as / 2;
    document.getElementById("ligesidet-cer").innerHTML = "Areal = " + AreLS.toFixed(2);
    /* retter punkterne i svg'en så trekanten bliver flyttet*/
    document.getElementById("ligesidettrekant").setAttribute("points", TPS * 20 + ",0 0," + as * 20 + " " + as * 20 + "," + as * 20);
}
