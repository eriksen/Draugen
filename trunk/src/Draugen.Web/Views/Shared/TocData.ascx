<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Model.Shared.MasterModel>" %>
<div id="toc">
    <%= Html.ActionLink("Art", "Detaljer", "Art", new RouteValueDictionary { {"name","torsk"}}, new Dictionary<string, object>{})   %>
    <a href="/" title="Draugens siste fangster">Fangster</a><br />
    <a href="#" title="Draugens forum">Draugprat</a><br />
    <a href="#" title="Draugens rekorder">Rekorder</a><br />
    <a href="#" title="Draugens resultatlister">Sammendraug</a><br />
    <a href="#" title="Logg inn og vis hvem du er">Logg inn</a>
    <br />
    <br />
    <br />
    <strong>Fiskerne våre:</strong><br />
    <a href="#" title="Draugling Joakims personlige rekorder(1)">Joakim</a><br />
    <a href="#" title="Draug Kim-frodes personlige rekorder(2)">Kim-frode</a><br />
    <br /><strong>Artene våre:</strong><br />
    <a href="#" title="Abbor fisket av Draugen">Abbor</a><br />
    <a href="#" title="asp fisket av Draugen">Asp</a><br />
    <strong>Fiskeplasser:</strong><br />
    <a href="#" title="Akerselva har gitt disse draugenfangstene">Akerselva</a><br />
    <a href="#" title="Belteren har gitt disse draugenfangstene">Belteren</a><br />
</div>
