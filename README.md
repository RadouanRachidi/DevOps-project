# PraiseUS

PraiseUs est une application web novatrice conçue pour améliorer la relation entre locataires et propriétaires en offrant une plateforme fiable pour référencer et évaluer la qualité des expériences locatives. Cette plateforme permet aux propriétaires et aux agences de créer des profils de locataires avec leur accord, en y intégrant des informations essentielles telles que le nom, le prénom, la nationalité et la date de naissance. À partir de ces profils, les utilisateurs peuvent ensuite publier des avis détaillés incluant des notes et des commentaires sur leur expérience.

Dans un esprit d'équité et de transparence, PraiseUs va plus loin en offrant également aux locataires la possibilité de créer à leur tour des fiches pour les propriétaires et de partager leur propre avis en fonction du déroulement du bail, ainsi que de noter l'état du logement. Cette approche bidirectionnelle assure que les deux parties ont une voix et que les avis sont équilibrés, encourageant ainsi un environnement locatif plus juste et plus transparent.

Animée par l'ambition de devenir une référence dans le secteur de l'immobilier, PraiseUs envisage d'introduire un système de classement des meilleurs logements, basé sur les évaluations reçues, pour orienter les futurs locataires dans leurs choix. Un système de notifications est également en cours de développement pour informer les locataires lorsqu'un avis est publié à leur sujet, et inversement, assurant ainsi une communication fluide et continue entre les parties.

L'objectif de PraiseUs est de forger une communauté où la confiance, le respect et l'appréciation mutuelle constituent les fondements de chaque interaction locative, transformant de ce fait le marché immobilier en un espace plus accueillant et professionnel pour tous.


# Règles de gestion

Règle de Gestion des Comptes Utilisateurs 

* Chaque utilisateur doit s'inscrire avec une adresse e-mail valide, et un mot de passe sécurisé conforme aux normes définies (longueur, complexité).
* Les utilisateurs doivent confirmer leur adresse e-mail via un lien d'activation envoyé à leur adresse pour finaliser la création du compte.

Règles de Gestion des Profils Locataires et Propriétaires

* Les profils de locataires créés par les propriétaires/agences nécessitent le consentement écrit du locataire, à obtenir via un mécanisme sécurisé intégré à l'application (par exemple, signature électronique).
* Les propriétaires ne peuvent créer des profils de locataire que pour des individus avec lesquels ils ont eu ou ont actuellement une relation contractuelle de location.

Règles de Gestion des Avis

* Les avis ne peuvent être soumis que pour des locations ayant existé pendant une durée minimale définie (6 mois).
* Chaque avis doit être associé à une période de location spécifique et chaque locataire et/ou propriétaire ne peux créer qu'un seul et unique avis pour le bailleur/locatire.
* Les avis doivent être modérables par les administrateurs de PraiseUs pour s'assurer qu'ils respectent les conditions d'utilisation de la plateforme.
 
Règles de Gestion des Notifications

* Les utilisateurs doivent pouvoir activer ou désactiver les notifications pour les nouveaux avis les concernant via les paramètres de leur compte.
* Une notification doit être envoyée automatiquement à un locataire ou propriétaire lorsque un nouvel avis sur son profil est publié ou lorsqu'un avis existant est modifié.

Règles de Gestion du Classement des Logements

* Le classement des logements est basé sur la moyenne des notes reçues dans les avis.
* Pour être éligible au classement, un logement doit avoir reçu un nombre minimum d'avis (5 avis).

Règles de Gestion de l'Intégrité des Données

* Les utilisateurs doivent avoir la possibilité de contester un avis s'ils estiment qu'il est inexact ou injuste, déclenchant ainsi un processus de révision par les administrateurs.
* Les données personnelles des utilisateurs ne peuvent être utilisées qu'aux fins de fonctionnement de PraiseUs et ne doivent pas être divulguées à des tiers sans consentement explicite.


# RBAC
| Permissions                                                   		      | Administrateur 	| Propriétaires/Agence Immobilière 	| Locataire 	| Visiteur 	|
|-----------------------------------------------------------------------|:--------------:	|:--------------------------------:	|:--------------:	|:----:	|
|                     	**Permission Administrateur**                 	  |                	|           						                  |                	|      	|
| Gérer les comptes utilisateurs (création, supression, suspension) 	   |        ✅       |     			❌     				               |        ❌       	|   ❌  	|
| Modérer les avis (validation, supression des avis inappropriés) 		    |        ✅       |     			❌     				               |        ❌       	|   ❌  	|
| Accéder à toutes les fiches locataires et propriétaires				           |        ✅       |     			❌     				               |        ❌       	|   ❌  	|
| Gérer le système de notifications et les paramètres de l'application	 |        ✅       |     			❌     				               |        ❌       	|   ❌  	|
| Analyser les données d'usage de l'application 						                  |        ✅       |     			❌     				               |        ❌       	|   ❌  	|
|            			**Permission Propriétaires/Agence**	           	        |                	|     			      				 |                	|      	|
| Créer des fiches locataire avec leur consentement					 	              |        ✅       |     			✅     				|        ❌      	|   ❌  	|
| Publier des avis sur les locataires									                          |        ✅       |     			✅     				|        ❌      	|   ❌  	|
| Recevoir des notifications sur les avis concernant 								
  leurs propriétés ou sur eux-mêmes										                           |        ✅       |     			✅     				|        ❌       	|   ❌  	|
| Consulter et répondre aux avis reçus									                         |        ✅       |     			✅     				|        ❌       	|   ❌  	|
|            			**Permission Locataire**	            		                 |                	|   							 	|                	|      	|
| Créer des fiches propriétaire											                              |        ✅       |     			❌     				|        ✅       	|   ❌  	|
| Publier des avis sur les propriétaires et logements					              |        ✅       |     			❌     				|        ✅       	|   ❌  	|
| Recevoir des notifications sur les avis publiés à leur sujet			       |        ✅       |     			❌     				|        ✅       	|   ❌  	|
| Consulter et répondre aux avis reçus									                         |        ✅       |     			❌     				|        ✅       	|   ❌  	|
|            **Permission Visiteir(Utlisateir non authentifié)**	       |                	|     			      				|                	|      	|
| Consulter les classements et les avis publics                       	 |        ✅       |     			✅     				|        ✅       	|   ✅  	|
| Rechercher des logements et propriétaires                       		    |        ✅       |     			✅     				|        ✅       	|   ✅  	|
