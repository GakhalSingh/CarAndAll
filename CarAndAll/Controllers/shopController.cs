using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/shop")]
public class ShopController : ControllerBase
{
    [HttpGet]
    public ContentResult Get()
    {
        return Content(@"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Home</title>
                <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css' rel='stylesheet'>
            </head>
            <body>
                <div id='navbar'></div>
                <div class='container'>
                    // hier komt dus je html brian
                </div>
            </body>
            <script>
                fetch('/navbar.html')
                    .then(response => response.text())
                    .then(html => {
                        document.getElementById('navbar').innerHTML = html;
                    });
                </script>
                <script src='https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js'></script>
            </html>
        ", "text/html");
    }
}
