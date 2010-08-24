<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Draugen.Services.ViewModels.Cards.TocCard>" %>

<div id="toc">
    <a href="/" title="Draugens siste fangster">Fangster</a><br />
    <a href="forum/index.php" title="Draugens forum">Draugprat</a><br />
    <a href="rekorder.php" title="Draugens rekorder">Rekorder</a><br />
    <a href="fiskere.php" title="Draugens resultatlister">Sammendraug</a><br />
    <a href="http://www.draugen.org/forum/login.php" title="Logg inn og vis hvem du er">Logg inn</a>
    <br />
    <br />
    <br />
    <strong>Fiskerne våre:</strong><br />
    <a href="rekorder.php?fiskerID=36" title="Draugling Joakims personlige rekorder(1)">Joakim</a><br />
    <a href="rekorder.php?fiskerID=28" title="Draug Kim-frodes personlige rekorder(2)">Kim-frode</a><br />
    <br /><strong>Artene våre:</strong><br />
    <a href="art.php?showall=true&amp;artID=10" title="Abbor fisket av Draugen">Abbor</a><br />
    <a href="art.php?showall=true&amp;artID=130" title="asp fisket av Draugen">Asp</a><br />
    <strong>Fiskeplasser:</strong><br />
    <a href="sted.php?showall=true&amp;stedID=43" title="Akerselva har gitt disse draugenfangstene">Akerselva</a><br />
    <a href="sted.php?showall=true&amp;stedID=23" title="Belteren har gitt disse draugenfangstene">Belteren</a><br />
</div>
