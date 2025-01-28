# README : Comprendre simplement le Factory Design Pattern

---

## À quoi sert le Factory Design Pattern ?

Le **Factory Design Pattern** est une méthode qui permet de **créer des objets** sans que le reste du code sache **comment** ces objets sont fabriqués. 

Au lieu d'utiliser directement `new` pour créer un objet, on fait appel à une **"factory" (usine)** qui s'occupe de fabriquer les objets pour nous.  

---

## Pourquoi utiliser ce modèle ?

### 1. Simplifie la création d'objets
- La Factory gère la création des objets à votre place.  
- Vous n'avez pas à vous soucier des détails complexes pour fabriquer un objet.

---

### 2. Facile à modifier ou à étendre
- Si vous devez ajouter un nouveau type d'objet, vous pouvez le faire en modifiant uniquement la Factory.  
- Le reste du code n'a pas besoin de changer.

---

### 3. Organise mieux le code
- Toute la logique de création est centralisée dans un seul endroit (la Factory).  
- Le reste du code reste clair et se concentre sur ce qu'il doit faire, sans se préoccuper de la création des objets.

---

## Quand l'utiliser ?

- Quand votre programme doit créer plusieurs types d'objets différents.  
- Quand la création d'objets est compliquée et répétitive.  
- Quand vous voulez rendre votre code plus flexible et facile à maintenir.  

---

En résumé, le Factory Design Pattern est une **façon intelligente de fabriquer des objets** pour garder un code plus propre, plus flexible, et facile à modifier.
