Dans cette exercice j’ai adopté une architecture 3 tiers en respectant les principes de développement SOLID (Single Responsibility, open/closed, Liskov substitution, Dependency Inversion).
La couche d’accès aux données: permet l’accès à la base de donnée avec Entity Framework Code First.
La couche service : contient du code métier pour le calcul de la distance entre deux aéroports ainsi que le carburant consommé. 
La couche middle : permet d’invoquer le service et de retourner le résultat au model MVC 5.
