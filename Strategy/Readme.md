# FabricationConfiture - Exemple du Pattern Strategy

Le **design pattern Strategy** est un modèle de conception comportemental qui permet de définir une famille d'algorithmes, de les encapsuler dans des classes séparées et de les rendre interchangeables à l’exécution. Ce modèle favorise la flexibilité et la réutilisabilité du code.

<p align="center">
  <img src="https://www.dofactory.com/img/diagrams/net/strategy.png" alt="Diagramme du Pattern Strategy">
</p>

Dans ce projet, nous implémentons ce pattern en simulant une **fabrication de confitures** utilisant plusieurs recettes, comme une **recette nouvelle**, une **recette sans gluten** et une **recette Bonne Maman**.

---

## Structure du projet

### 1. **Interfaces**

L'interface `IConfitureRecette` permet de standardiser toutes les recettes de confiture. Toutes les implémentations concrètes (comme `RecetteNouvelle`, `RecetteSansGluten`, et `RecetteBonneMaman`) doivent suivre cette interface.

### 2. **Stratégies (Recettes)**

Chaque recette implémente l'interface `IConfitureRecette` pour encapsuler un comportement spécifique :

- **RecetteNouvelle** : Recette moderne avec peu de sucre.
- **RecetteSansGluten** : Recette garantie sans gluten.
- **RecetteBonneMaman** : Recette classique avec une forte teneur en sucre.

### 3. **Classe FabricationConfiture (Context)**

La classe `FabricationConfiture` agit comme un "context" qui utilise une stratégie donnée pour produire la confiture.

### 4. **Classe Program (Main)**

La classe `Program` utilise les différentes recettes en les passant dynamiquement à la classe `FabricationConfiture`.

---

## Avantages du Pattern Strategy

1. **Flexibilité** : Vous pouvez facilement ajouter de nouvelles recettes sans modifier le code existant.
2. **Modularité** : Chaque recette est encapsulée dans une classe distincte, facilitant la maintenance.
3. **Respect des principes SOLID** :
   - **Single Responsibility Principle** : Chaque classe a une seule responsabilité (une recette spécifique).
   - **Open/Closed Principle** : Le système est ouvert à l'extension (ajout de nouvelles recettes) mais fermé à la modification (aucun besoin de changer le code existant).
4. **Testabilité** : Les stratégies sont facilement testables de manière ind
