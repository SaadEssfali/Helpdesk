# Helpdesk

Application desktop de gestion de tickets d’assistance technique, développée en **C# WinForms (.NET 6)** avec **SQL Server**.

## Aperçu

Helpdesk permet de centraliser les demandes de support informatique, de suivre leur traitement et de faciliter la coordination entre employés, techniciens et administrateurs.

Le projet couvre le cycle complet d’un ticket : création, prise en charge, suivi, résolution et historisation.

## Fonctionnalités principales

### Employé
- Authentification et accès à un espace dédié
- Création de tickets (catégorie, description, priorité)
- Consultation de l’historique des tickets
- Suivi des notifications liées aux tickets

### Technicien
- Visualisation des tickets non assignés
- Prise en charge d’un ticket
- Gestion des tickets en cours / résolus
- Consultation de l’historique des interventions
- Tableau de bord de suivi (tickets ouverts/résolus)

### Administrateur
- Gestion des employés
- Gestion des techniciens
- Gestion des tickets
- Tableau de bord global (volumétrie tickets/utilisateurs)

## Stack technique

- **Langage** : C#
- **Framework** : .NET 6 Windows Forms
- **Base de données** : SQL Server (connexion locale `.\SQLEXPRESS`)
- **Packages NuGet** :
  - `System.Data.SqlClient`
  - `MaterialSkin.2`

## Prérequis

- Windows (application WinForms)
- .NET SDK 6.0+
- SQL Server / SQL Express
- Base de données `helpdesk_db` avec les tables attendues par l’application :
  - `Employe`, `Technicien`, `Ticket`, `Intervention`, `NotificationLog`, `CategorieProbleme`

## Installation et exécution

1. Cloner le dépôt.
2. Ouvrir `Helpdesk.sln` dans Visual Studio.
3. Vérifier la chaîne de connexion SQL Server dans :
   - `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/Program.cs`
4. Restaurer les dépendances NuGet.
5. Compiler puis lancer le projet `Helpdesk`.

## Authentification (démo)

- **Admin** : `admin` / `admin` (défini en dur dans la logique de connexion)
- **Employé / Technicien** : comptes stockés en base SQL Server

## Structure du projet

- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/Form1.cs` : écran de connexion
- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/MainForm.cs` : interface employé
- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/TechnicienForm.cs` : interface technicien
- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/AdminForm.cs` : interface administrateur
- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/UserControls` : composants UI employés
- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/usercontroltech` : composants UI techniciens
- `/home/runner/work/Helpdesk/Helpdesk/Helpdesk/AdminUserControls` : composants UI administrateurs

## Objectif du projet

Ce projet académique (EFM) a permis de mettre en pratique :
- la conception d’une application métier orientée support
- le développement collaboratif en équipe
- l’intégration d’une interface desktop connectée à une base relationnelle
