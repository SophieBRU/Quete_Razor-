# Quete_Razor@

# Challenge
Un peu de ménage !
Copie-colle ce code-ci et rends le plus propre en séparant la présentation du formatage.


@{
    String conclusion = String.Empty;
    Int32 sum = Model.Sum(m => m.Amount);
    if (sum > 10000000)
    {
        conclusion = "You earn too much money";
    }
    else
    {
        conclusion = "You should ask for a salary raise";
    }
}

<div class="container">
    @conclusion
</div>

# Critères de validation
Un contrôleur traite les données à envoyer à la vue avant d'en faire un rendu
Aucune condition ni boucle n'est présente dans le fichier .cshtml
