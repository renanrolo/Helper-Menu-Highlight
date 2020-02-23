Esse projeto foi um dos meus primeiros projetos, a idéia era somente identificar se o usuário estava na mesma página do link do menu para então estilizar o link. Fiz utilizando um helper para ficar bem fácil a utilização.


### Uso
Veja que o helper 'Html.ClasseHighlight' apenas adiciona a classe 'active' no link do navbar.

```
<ul class="nav navbar-nav">
    <li class="@Html.ClasseHighlight("Index", "Home" )">@Html.ActionLink("Home", "Index", "Home")</li>
    <li class="@Html.ClasseHighlight("About", "Home")">@Html.ActionLink("About", "About", "Home")</li>
    <li class="@Html.ClasseHighlight("Contact", "Home")">@Html.ActionLink("Contact", "Contact", "Home")</li>
    <li class="@Html.ClasseHighlight("Index", "Exemplo")">@Html.ActionLink("Exemplo", "Index", "Exemplo")</li>
    <li class="@Html.ClasseHighlight("Teste", "Exemplo")">@Html.ActionLink("Teste", "Teste", "Exemplo")</li>
</ul>
```
___
# Helper-Menu-Highlight
Helper para inserir classe (CSS) que dá HightLight no link do Menu que seja igual ao mesmo Controller/Action.
