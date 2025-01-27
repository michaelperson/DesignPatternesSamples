Le Design Pattern Composite
- C'est un concept qui permet de donner des spécificités aux objets dits enfants, qui découlent d'un objet parent. 
Afin de hierarchiser et de simplifier les tâches.

Représenté sous forme d'arborescence, on distingue le type primitif("la feuille") du type composite("le composite"). Le premier ne permettant pas de créer de nouveau lignage alors que le type composite permet d'en décliner de nouveaux.
Concrètement parlant, le type composite permet d'intégrer de nouvelles fonctions, de créer de nouvelles branches, etc

Un désavantage est que Le Composite peut parfois rendre difficile l'encapsulation de comportements spécifiques. Par exemple, si un client souhaite accéder uniquement à certains types d'objets (par exemple, uniquement les feuilles ou uniquement les composites), il peut être difficile de restreindre l'accès à ces types sans créer de code supplémentaire pour gérer la vérification du type d'objet. Cela peut introduire de la confusion et une gestion complexe de la logique.

Son avantage est qu'il fournit un moyen naturel de modéliser les relations entre les objets. La hiérarchie d’objets est clairement définie, et chaque composant, qu'il soit une "feuille" ou un "composite", peut être utilisé de manière flexible.
