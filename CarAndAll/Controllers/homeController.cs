using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/home")]
public class HomeController : ControllerBase
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
                    <h1>Welkom!</h1>
                    <img src='/img/Dunlop__Finpins_Joos.png' alt='logo' class='img-fluid'>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                </div>
                <script>
                    fetch('/navbar.html')
                        .then(response => response.text())
                        .then(html => {
                            document.getElementById('navbar').innerHTML = html;
                        });
                </script>
                <script src='https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js'></script>
            </body>
            </html>
        ", "text/html");
    }
}
