// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function capture() {
    html2canvas(document.body).then((canvas) => {
        let a = document.createElement("a");
        a.download = "ss.png";        
        a.href = canvas.toDataURL("image/webp");
        console.log(a.href);
        a.click();
    });
}