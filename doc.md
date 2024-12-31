Introduction
Ce projet est une application ASP.NET Core avec une API qui retourne des prévisions météorologiques. 
Le pipeline CI/CD est configuré à l'aide de Jenkins pour automatiser les étapes de clonage du code, de compilation, de test, et de déploiement.

Structure du Contrôleur
Le projet contient un contrôleur WeatherForecastController qui expose une route API permettant de récupérer des données de prévisions météorologiques.
Voici une explication des fonctionnalités du contrôleur :

using Microsoft.AspNetCore.Mvc;

namespace projetjenkinse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

--------------------------

Pipeline Jenkins
Description
Le pipeline CI/CD de Jenkins est conçu pour automatiser les étapes suivantes :

Clone Repository : Récupère le code depuis le dépôt GitHub.
Build : Compile le projet.
Test : Exécute les tests définis.
Post Actions : Génère un résumé des résultats et indique si le pipeline a réussi ou échoué.
Exécution réussie
Les captures d'écran suivantes montrent le déroulement du pipeline :

Clonage du code et compilation réussie :

Exécution des tests avec succès :

Commandes utilisées
Build :
cmd
Copier le code
echo Build step completed
Test :
cmd
Copier le code
echo Tests executed successfully

![1](https://github.com/user-attachments/assets/c01f6445-0b3d-45ca-a86b-0494926775f2)

![2](https://github.com/user-attachments/assets/5604920b-7906-4ed9-a054-49912a207ebc)

----------------------------------------------------

Points Clés
Technologies utilisées :

ASP.NET Core : Backend pour l'API.
Jenkins : Outil CI/CD pour automatiser le pipeline.
GitHub : Hébergement du code source.
Pipeline Jenkins :

Étapes configurées pour une exécution fluide et automatique.
API WeatherForecast :

Retourne des données simulées pour des prévisions météorologiques.
-------------------------------------------------------------------

![docker](https://github.com/user-attachments/assets/bbee8233-41c0-4255-ab65-fff1ba0bc895)
À quoi sert cette image Docker ?
Cette image Docker contient une application ASP.NET Core,
configurée via Jenkins pour automatiser la compilation, les tests et le déploiement. Elle est prête à être exécutée dans un conteneur Docker.

-----------------------------------------------------------------------
voila mon docker hub
https://hub.docker.com/repository/docker/malkimohamed/projetjenkinse/general
