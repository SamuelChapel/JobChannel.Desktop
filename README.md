<h1>JobChannel : Solutions pour l’Insertion Professionnelle</h1>

<h2>Introduction</h2>
Le service d'insertion de l'association AMIO gère les offres d'emploi pour les stages, l'alternance et les emplois. 

Ces offres proviennent de diverses sources et sont ensuite transmises par e-mail aux stagiaires. 

Pour améliorer la mise à disposition des offres d'emploi et impliquer davantage les stagiaires dans leurs recherches, 
j'ai développé une solution contenant différentes applications.

Ce repository est pour l'application desktop de cette solution.

<h2>Architecture Globale</h2>
JobChannel adopte une architecture en couches pour séparer les responsabilités et faciliter la maintenance. 

Voici les applications de cette solution :

1. **Partie Serveur**:
    - Base de données relationnelle : Utilisation de **SQL Server** comme SGBDR pour stocker les données des offres d'emploi.
    - **API REST** avec le **Framework ASP.NET 6**. Cette API servira d'intermédiaire entre la base de données et les applications clientes.

2. **Partie Client**:
    - **Application Desktop pour les Conseillers d'Insertion**:
        - Application **WinForms** pour permettre aux conseillers d'insertion de gérer les offres d'emploi mises à disposition des stagiaires.
    - **Application Mobile pour les Stagiaires**:
        - Pour les stagiaires, application **UWP** (Universal Windows Platform) avec une architecture **MVVM**. Cette application permettra aux stagiaires de consulter les offres d'emplois.

<h2>Tests</h2>
Les test ont étés éffectués tout au long du développement en utilisant des **tests unitaires** et des **tests d'intégration** avec le framework **xUnit**.

---

<h1>JobChannel Desktop</h1>

<h2>Introduction</h2>
L’application desktop qui sera utilisée par les conseillers d’insertion afin de gérer les offres d’emploi a été réalisée en C# avec l’interface utilisateur Windows Forms.

Elle va récupérer les données des offres d’emploi par l’intermédiaire de requêtes http à l’API de l’application serveur.

<h2>Architecture</h2>

L’architecture de l’application desktop comme pour l’application serveur est en couche avec :

  - Une couche de présentation qui contient les Windows Forms et donc l’interface utilisateur
  - Une couche BLL qui contient les services
  - Une couche DAL qui contient l’accès aux données par l’intermédiaire du client http

Comme pour l’application serveur, j’utilise l’injection de dépendance par l’intermédiaire d’un container d’injection afin de découpler au maximum les classes entre elles.

<h2>Ecran de l'application</h2>

<img src="https://github.com/SamuelChapel/JobChannel.Desktop/assets/86355019/b5096ef5-abda-46d5-a493-303376a589c6"/>

La fenêtre principale affiche dès que l’on ouvre l’application les 30 offres d’emploi les plus récentes.

---
  
<img src="https://github.com/SamuelChapel/JobChannel.Desktop/assets/86355019/b5f57f1d-8461-451e-9d86-1776fe2c7f1d" width=200 />
  
Un tri peut-être réalisé par les filtres à gauche pour trier par région et ensuite affiner le tri par département, et enfin par ville.
  
---

<img src="https://github.com/SamuelChapel/JobChannel.Desktop/assets/86355019/ac799f26-c003-43ad-8189-5da110163748"/>

La barre de recherche- en haut permet une recherche générale sur presque tous les champs (titre, url, poste, contrat, région, département, ville, entreprise, …)
