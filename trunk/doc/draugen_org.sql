-- phpMyAdmin SQL Dump
-- version 2.9.2-Debian-1.one.com1
-- http://www.phpmyadmin.net
-- 
-- Host: MySQL Server
-- Generation Time: Aug 22, 2010 at 06:17 PM
-- Server version: 5.0.51
-- PHP Version: 5.2.0-8+etch16
-- 
-- Database: 'draugen_org'
-- 

-- --------------------------------------------------------

-- 
-- Table structure for table 'art'
-- 

CREATE TABLE art (
  ID int(11) NOT NULL,
  navn varchar(50) NOT NULL default '',
  nrgram int(11) NOT NULL default '0',
  kommentar text NOT NULL,
  PRIMARY KEY  (ID)
);

-- 
-- Dumping data for table 'art'
-- 

INSERT INTO art VALUES (8, 'Torsk', 37500, 'Gadus morhua er kanskje den vanligste fisken i våre farvann. Den er ihvertfall den letteste å få tak i. Torsken lever fra fjæra til 600 meters dyp. Den lever dels som bunnfisk og dels pelagisk. Det er særlig stor torsk som går pelagisk.');
INSERT INTO art VALUES (9, 'Lake', 7000, 'Lota lota finnes om sommeren på opptil 200 meters dyp, men finnes grunnere om vinteren. Den finnes i store elver og innsjøer med utpreget kaldt vann. Unge fisker svømmer mest på grunt vann, mens større, eldre fisker finnes dypere. Laken finnes både på bløtbunn og på steinbunn. Om dagen er den passiv, ihvertfall om sommeren. Ungfisker lever av døgnfluelarver, tanglopper og andre krepsdyr, mens større fisker fisker tar stort sett fisk. Laken tar mest føde til seg i vinterhalvåret.');
INSERT INTO art VALUES (10, 'Abbor', 3170, 'Perca fluviatilis forekommer fra standkanten og ned til 60 meters dyp. Som ung er abboren stimfisk, mens eldre fisker gjerne er solitære. Abboren samler seg gjerne ved trerøtter, synketømmer, vegetasjon, brygger og brokar. I dype oksygenrike innsjøer går den ned til største dyp. Abboren tar insektlarver, krepsdyr og småfisker. Større individer lever vesentlig av fisk som krøkle, hork, mort, laue og yngre abbor. Abboren er stasjonær, men vandringer kan forekomme i større vann.');
INSERT INTO art VALUES (11, 'Ørret', 15300, 'Salmo trutta spiser står gjerne foran eller bak en stein og fanger opp larver, døgnfluer, små muslinger, snegler og andre krepsdyr som farer forbi. Større ørret spiser fisk.');
INSERT INTO art VALUES (12, 'Sik', 4150, 'Coregonus lavaretus er en stimfisk og spiser bunndyr, men også egen rogn, plankton og kan også ta fiskeyngel. Det sies at fluefiske etter sik på kvelden gir de største fangstene.');
INSERT INTO art VALUES (13, 'Karuss', 2784, 'Carassius carassius finnes i stille vann med rik vegetasjon. Den lever av hoppekreps, mark, vanninsekter og råtnende planter samt mygglarver.');
INSERT INTO art VALUES (14, 'Sjøørret', 13200, 'Salmo trutta spiser står gjerne foran eller bak en stein og fanger opp larver, døgnfluer, små muslinger, snegler og andre krepsdyr som farer forbi. Større ørret spiser fisk. Samme art som Ørret, men lever i sjøen og gyter i elver.');
INSERT INTO art VALUES (15, 'Hvitting', 3115, 'Merlangius merlangus er vanligvis en bunnfisk på 10 til 200 meters dyp, men opptrer dels pelagisk. Sand og mudderbunn er favoritten, men den kan treffes på alle bunntyper. Små fisk står gjerne ved strendene, mens større fisk står på større dyp og lenger bort fra kysten.');
INSERT INTO art VALUES (16, 'Hyse', 7413, 'Melanogrammus aeglefinus finnes mest på 40 til 300 meters dyp. Den er en bunnfisk som foretrekker sandblandet leir- og grusbunn, og den finnes også over ren sandbunn. Her lever den av rogn, fisker, små blekkspruter og bunndyr som sjøstjerner, snegler, forskjellige krepsdyr og børstemark.');
INSERT INTO art VALUES (17, 'Knurr', 958, 'Eutrigla gurnardus lever på 10 til 50 meters dyp, sjeldnere ned til 150 meter. Trives best på sandbunn, men finnes også mudderbunn, skjellbunn og også på stein- eller klippebunn. Om sommeren svømmer den også fritt i sjøen. Føden er først og fremst forskjellige reker, men tar også fisker.');
INSERT INTO art VALUES (18, 'kveite', 202000, 'Hippoglossus hippoglossus holder til på 300 til 2000 meters dyp, mens yngere individer  kan finnes langst kysten på relativt grunt vann. Kveita lever på mange slags bunn, men jager også bytte i alle lag av sjøen. Den viktigste føden er fisk, men også blekksprut, sjøkreps og andre bunndyr. ');
INSERT INTO art VALUES (19, 'lange', 40000, 'Molva molva forekommer på 60 til 1000 meters dyp, men er vanligst på 300 til 400 meter. Det er som regel bare ungfisker som finnes grunnere enn 100 meter. Arten svømmer alene eller i små stim ved hard bunn eller sandbunn med store steiner. Føden er hovedsaklig fisker som uer, hyse, torsk og flyndrer, mens ungfisker tar mest blekksprut og krepsdyr.');
INSERT INTO art VALUES (20, 'lusuer', 777, 'Sebastes viviparus lever fra 10 til 200 meters dyp. Yngre fisker lever gjerne pelagisk. Føden er krepsdyr muslinger og småfisker.');
INSERT INTO art VALUES (21, 'Lyr', 12800, 'Pollachius pollachius lever pelagisk, dels ved bunnen, ned til ca. 200 meters dyp. Store fisker finnes hyppigst ved fjell- og steinbunn, yngre fisker også over sandbunn, elvemunninger og i havner. Føden er fisk, særlig sil og arter i silde og torskefamiliene. Den tar også større krepsdyr som reker og krabber.  OM vinteren trekker lyren ut på dypere vann. om sommeren er det vanlig å se lyr alene eller i stim nær land.');
INSERT INTO art VALUES (22, 'Makrell', 3474, 'Scomber scombrus er en pelagisk og hurtigsvømmende fisk. Makrellen har tilhold i de øvre vannlag om sommeren, mens den går ned på 200 til 250 meter på vinteren. Om vinteren spiser den lite. Voksen makrell tar mest krepsdyr eller yngell av brisling, sild og torskefisker, men også makrellunger. Pir eller småmakrellen går ofte i stim med større makrell.');
INSERT INTO art VALUES (23, 'paddetorsk', 750, 'Raniceps raninus finnes ofte på grunt vann, sjeldnere ned mot ca. 100 meters dyp. Den liker seg best på tangbevokst steinbunn, men kan også opptre på sandbunn og mudderbunn. Den lever enkeltvis og befinner seg ofte i skyggen under brygger og steiner. Føden er børstemark, pigghuder, reker og småfisker.');
INSERT INTO art VALUES (24, 'sandflyndre', 1192, 'Limanda limanda lever på 2 til 150 meters dyp. Ungfiskene lever hovedsaklig nær strendene, mens eldre fisker finnes dypere, helst på sand- og bløtbunn. Om sommeren inntreffer en vandring av større individer mot nære kystområder. Arten tar stort sett alle typer hvirvelløse dyr; mest muslinger, mark, tanglus, tanglopper og larver av dansemygg. ');
INSERT INTO art VALUES (25, 'Sei', 22700, 'Pollachius virens forekommer både pelagisk og som bunnfisk, fra 0 til 300 meters dyp. Stor sei står gjerne noe dypt og jager fiskeyngel, sild, brisling og pelagiske krepsdyr. Seien jakter gjerne kollektivt. ');
INSERT INTO art VALUES (26, 'bergnebb', 126, 'Ctenolabrus rupestris er om sommeren en utpreget art i fjæra og ned til 10 til 20 meters dyp, men om vinteren trekker den ut på dypere vann, gjerne ned til 50 meter. Den liker seg på algerike steder ved steinbunn og bryggestolper på relativt grunt vann. Føden er muslinger og krepsdyr.');
INSERT INTO art VALUES (28, 'Røye', 8285, 'Salvelinus alpinus trives i både hurtigstrømmende vann og i dype kalde innsøer. Den lever av små krepsdyr, mygglarver og -pupper, og den tar også andre insekter, snegler og muslinger.');
INSERT INTO art VALUES (124, 'Skrubbe', 2930, 'Platichthys flesus lever fra fjæra og ned til 120 meters dyp. Den liker seg best løs og hard bunn med algevegetasjon. Føden er alle typer bunndyr; mest muslinger, mark, tanglus, tanglopper, reker og småfisker som kutlinger og sil. Ikke kjønnsmodene individer kan også svømme langt opp i elver om sommeren.');
INSERT INTO art VALUES (125, 'uer', 9020, 'Sebastius marinus finnes på 100 til 500 meters dyp, men også mesopelagisk. Ueren trives best på bratt klippebunn på kontinentalskråningen. Arten spiser krill, lodde, silde- og torskefisker.\r\nUeren kan trolig bli over 60 år gammel.');
INSERT INTO art VALUES (126, 'Sild', 720, 'Clupea harengus lever fra overflaten og ned til 200 meter. Silda svømmer i stim, pelagisk eller nær bunnen. Nær bunnen om dagen og nær overflaten om natten. Føden er planktoniske krepsdyr, vingesnegler og fiskeyngel.');
INSERT INTO art VALUES (127, 'mort', 1058, 'Rutilus rutilus lever i innsjøer og tilstøtende elver, ofte i store stimer. Vanligvis er morten tilknyttet vegetasjonen i strandsoner og på grunner, men i vann med store bestander lever den mest pelagisk og beiter på zooplankton. Føden er mest insektlarver, men også krepsdyr snegler og små muslinger.');
INSERT INTO art VALUES (128, 'vederbuk', 2880, 'Leucisus idus tåler godt brakkvann og finnes derfor ofte i elvemunninger. Vederbuken foretrekker stilleflytende elver eller innsjøer med klart vann, men finnes også på grumsete steder. Den ferdes ofte i stim, eldre fisker vanligvis ved steinbunn mens yngre fisker finnes ved vegetasjonsrike strandbredder. Føden er variert med hovedvekt på insektlarver og insekter, muslinger, snegler, krepsdyr og planteføde. Større individer tar også fisker som mort og laue.');
INSERT INTO art VALUES (129, 'taggmakrell', 1163, 'Trachurus trachurus finnes fra overflaten og ned til 100 meters dyp. Taggmakrellen er en pelagisk stimfisk som ofte opptrer sammen med makrell i de øvre vannlag. Spiser bunndyr om vinteren. Om sommeren plankton og yngel av brisling og sild. Store individer tar også blekkspruter.');
INSERT INTO art VALUES (130, 'asp', 5340, 'Aspius aspius finnes mest i elver med moderat strøm og i store innsjøer. Mindre fisker jager i stim og tar fisk, blant annet mort. Større fisk tar også amfibier og jager oftest alene. Det sies at Aspen biter best morgen og kveld.');
INSERT INTO art VALUES (131, 'Brasme', 5526, 'Abramis brama foretrekker grunne innsjøer med rik plantevekst og finnes mest i stille langsomtflytende vann. Den forekommer oftest på leir- og slambunn. Brasmen kan også finnes i brakkvann. Brasmen spiser bunndyr som mark, muslinger og snegler. Større individer kan også ta fisk.');
INSERT INTO art VALUES (132, 'Gjedde', 17700, 'Esox lucius trives best i grunne, vegetasjonsrike vann. Den lever også i elver og brakkvann. Gjedda spiser fisk, frosker, vannfugler, vannrotter, slanger og alt annet som rører seg og ikke er for stor for den.');
INSERT INTO art VALUES (133, 'Flire', 1015, 'Blicca bjoerkna finnes i grunne lavlandssjøer med rik vegetasjon hvor de svømmer i stim. Den spiser bunnlevende animalsk føde som de graver ut av bunnsedimentene.');
INSERT INTO art VALUES (134, 'Horngjel', 1630, 'Belone belone er en pelagisk art som svømmer i øvre vannlag. Føden består av småfisk som yngel, brisling, sild og sil, samt planktoniske krepsdyr og blekkspruter. Horngjelen bruker synet i jakten og jakter derfor stor sett om dagen.');
INSERT INTO art VALUES (135, 'Gjørs', 11080, 'Stizostedion lucioperca er den mest utpregede rovfisken blant våre abborfisker. Gjørsen er kresen med hensyn til tilholdssted. Den liker varme, leirete og ikke alt for grunne innsjøer, vassdrag med lite strøm og svakt brakkvann. Den unngår steder med sterk vegetasjon og svømmer enten fritt i vannmassene eller nær bunnen et stykke fra land i store innsjøer. Om sommeren er gjørsen mest aktiv om natten. Fisker eldre enn et år lever bare av fisk som laue, lagesild, krøkle, sik og mort.');
INSERT INTO art VALUES (136, 'stam', 3430, 'Leuciscus cephalus liker seg best i langsomtflytende elver med forholdsvis klart vann. Voksen stam svømmer stort sett alene. Større stam tar fisker og kreps, til dels også vannrotte og frosk.');
INSERT INTO art VALUES (137, 'Ørekyte', 40, 'Phoxinus phoxinus trives best i klare strømmende elver, men finnes også i innsjøer og tjern med stein- eller grusbunn. Svømmer i stim og beveger seg mest i overflaten. Spiser insekter og insektlarver, samt plantemateriale.');
INSERT INTO art VALUES (138, 'Gråsteinbit', 17600, 'Anarhichas lupus lever fra fjæra og ned til 435 meter dyp. Liker seg på tangbevokst steinbunn og går i gytetiden helt opp i fjæra. Gråsteinbiten spiser pigghuder, muslinger, snegler og krabber.');
INSERT INTO art VALUES (139, 'brosme', 17200, 'Brosme brosme forekommer på 50 til 1000 meter, men er mest vanlig på 200 til 500 meters dyp. Lever ved fjell- og steinbunn. Spiser mest reker og krabber, men også børstemark, muslinger og små bunnfisker.');
INSERT INTO art VALUES (140, 'sypike', 388, 'Trisopterus minutus finnes fra 10 til 300 meters dyp, men er mest vanlig ned til 100 meter. Spiser hovedsaklig krepsdyr og små fisker.');
INSERT INTO art VALUES (141, 'Hork', 75, 'Acerina ceruna er en treg bunnfisk i innsjøer og langsomme elver. Horken lever også i brakkvann. Horken er næringskonkurrent med brasme og flire og graver gjerne dypt for å få tak i bunndyr som fjærmygglarver og muslinger. Hork spiser også fiskeyngel og rogn.');
INSERT INTO art VALUES (142, 'Laue', 100, 'Alburnus alburnus svømmer stort sett i stim og jager etter planktoniske smådyr og insekter. Mark er effektivt etter Laua. Laue er kanskje mest interessant som agn til større rovfisk i området.');
INSERT INTO art VALUES (143, 'suter', 3700, 'Tinca tinca trives i tett bunvegetasjon og forekommer ikke over steinbunn. Suteren er aktiv om natten og svømmer gjerne i små stim. Ligger i dvale om vinteren. Føden er små muslinger, snegler og insektlarver, gjerne mygglarver og plantedeler.');
INSERT INTO art VALUES (144, 'sørv', 1340, 'Sardinius erythrophhalmus skilles fra mort ved at ryggfinnen er festet tydelig bak bukfinnene. Sørven lever i små stim i vegetasjonsbeltet på grunt vann. Den spiser planteføde, snegler og insektlarver. Sørven har mange navn og kalles også flossmort, planke, plunke, sorv, syrje, syrril og sørje.');
INSERT INTO art VALUES (145, 'dvergmalle', 540, 'Ictalurus nebulosus er en nattaktiv bunnfisk. Liker seg på bløt bunn. Føden er mygglarver, vårfluelarver, muslinger, rogn og småfisk.');
INSERT INTO art VALUES (146, 'harr', 1900, 'Thymallus thymallus er utbredt i kalde elver og oksygenrike vann. Harren svømmer i stim først og frems ved steinbunn. Føden er plankton, insekter og krepsdyr. Stor harr kan ta småfisk.');
INSERT INTO art VALUES (147, 'Ål', 3850, 'Anguilla anguilla spiser fisker, rogn, krepsdyr, snegler, muslinger og insektlarver. Stor ål kan også ta frosk og andunger. Ål som vokser opp i ferskvann blir hunner, mens ål som vokser opp i brakkvann blir hanner. Ålen gyter i Sargassohavet, men ingen vet hvordan den kommer seg dit.');
INSERT INTO art VALUES (148, 'blåstål (rødnebb)', 1050, 'Laborus binaculatus er en gyltefisk som lever på 5 til 500 meters dyp, men er vanligst under  40 meter. Liker seg ved bergvegger. Hannen kalles blåstål og hunnen kalles rødnebb, men de er altså begge samme art.');
INSERT INTO art VALUES (149, 'småflekket rødhai', 1340, 'Scyliorhinus caniculus trives best på mudder og sandbunn fra fjære og ned til 100 meters dyp.Som navnet antyder er den dekket med små mørke flekker på ryggsiden. Grunnfargen er sand- eller brunfarget. Også noen lysere flekker. Halefinnen er åreformet.\r\n\r\n');
INSERT INTO art VALUES (150, 'rødknurr', 1635, '');
INSERT INTO art VALUES (151, 'berggylte', 3200, 'Dette er den største av våre leppefisker. Kroppsformen er kraftig, med stor høyde i forhold til lengden.Om sommeren er dette en meget vanlig art i tarebeltet i den ytre skjærgård. Om vinteren trekker den ned på dypere vann. Ned til 200 m. ');
INSERT INTO art VALUES (153, 'rødspette', 5175, 'Kanskje den av våre flatfisk som er best kjent og høyest skattet. Den er høyrevent. Øyesiden er glatt, foruten de 4-7 karakteristiske benknutene fra øynene bakover på gjellelokket og til fremste del av sidelinjen. Brun, eller brungrå øyeside med en rekke røde flekker, også på finnene.');
INSERT INTO art VALUES (154, 'fjesing', 650, 'Langstrakt fisk med brun og blågrønn metallisk marmorering. Nedre halvdel er lys med lysebrune spetter. Kroppen smalner jevnt av bakover mot halefinnen. Markert underbitt. Øynene sitter høyt og langt fram. En kort og en lang ryggfinne. Den korte med 5-7 piggstråler. De to første av disse er likhet med piggen på gjellelokket forbundet med en giftkjertel.');
INSERT INTO art VALUES (155, 'grønngylt', 190, 'Liten leppefisk som kjennes på den mørke nyreformede flekken bak øyet, og en mørk flekk ved haleroten. Flekkene er ikke alltid like tydelige. Hannen er vakkert marmorert i grønt, blått og brunt. Hunnene er mer ensfarget brun. Ryggfinnen med 15-18 piggstråler og 8 bløtstråler. Gattfinnen har 8-10 bløtstråler og 3 piggstråler.');
INSERT INTO art VALUES (156, 'slimål', 120, 'Mye slim, men smaker slett ikke værst');
INSERT INTO art VALUES (157, 'breiflabb', 57500, '');

-- --------------------------------------------------------

-- 
-- Table structure for table 'fangst'
-- 

CREATE TABLE fangst (
  ID int(11) NOT NULL,
  fiskerID int(11) NOT NULL default '0',
  artID int(11) NOT NULL default '0',
  stedID int(11) NOT NULL default '0',
  dato date NOT NULL default '0000-00-00',
  gram int(11) NOT NULL default '0',
  millimeter int(11) NOT NULL default '0',
  redskap varchar(50) NOT NULL default '',
  kommentar text NOT NULL,
  godkjent tinyint(4) NOT NULL default '0',
  PRIMARY KEY  (ID)
);

-- 
-- Dumping data for table 'fangst'
-- 

INSERT INTO fangst VALUES (7, 25, 8, 8, '2002-07-14', 4100, 0, 'Pilk', 'Min Historie', 1);
INSERT INTO fangst VALUES (9, 25, 12, 47, '2004-02-22', 200, 0, 'Pilk', 'Mangler, Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (11, 25, 26, 7, '2001-06-12', 50, 0, 'makrellagn på bunnen', 'Kasta agn ut fra Langøyene på sia mot Rambergøya. Steinete og fjellete plass. Dårlig fiske den dagen. Dette var det eneste som bet på.', 1);
INSERT INTO fangst VALUES (12, 11, 25, 8, '2001-07-27', 1500, 0, 'Dorging med gummimakk', 'Mangler', 1);
INSERT INTO fangst VALUES (13, 9, 21, 8, '2002-07-01', 2100, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (14, 9, 20, 8, '2002-07-01', 150, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (15, 9, 16, 8, '2002-07-01', 450, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (16, 9, 8, 8, '2002-07-03', 1500, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (17, 9, 10, 47, '2003-06-06', 100, 0, 'Meite', 'Mangler, Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (18, 9, 25, 8, '2002-07-01', 800, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (19, 8, 17, 9, '2001-05-24', 375, 0, 'Stingsild langs bunnen', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (20, 8, 8, 9, '2001-05-24', 2100, 0, 'Stingsild', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (21, 8, 8, 8, '2002-07-23', 3000, 0, 'Stripete sildesluk', 'Mangler', 1);
INSERT INTO fangst VALUES (22, 10, 16, 8, '2001-07-27', 700, 0, 'Hekle', 'Mangler, Grønøystilla', 1);
INSERT INTO fangst VALUES (23, 7, 20, 8, '2002-07-23', 110, 0, 'Dorg', 'Mangler', 1);
INSERT INTO fangst VALUES (24, 7, 16, 8, '2002-07-23', 600, 0, 'Dorg', 'Mangler', 1);
INSERT INTO fangst VALUES (25, 7, 10, 23, '2002-08-18', 250, 0, 'Nark på bunnen', 'Mangler', 1);
INSERT INTO fangst VALUES (26, 7, 8, 8, '2001-07-23', 2000, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (27, 7, 25, 8, '2002-07-21', 800, 0, 'Dorg', 'Mangler', 1);
INSERT INTO fangst VALUES (28, 7, 11, 32, '2002-07-18', 350, 0, 'Mark og dupp', 'Mangler', 1);
INSERT INTO fangst VALUES (29, 2, 21, 8, '2002-07-15', 6000, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (30, 2, 24, 9, '2001-07-06', 375, 0, 'Makrellagn på bunnen', 'Mangler, Fredvikberget.', 1);
INSERT INTO fangst VALUES (32, 2, 22, 9, '2002-05-26', 750, 0, 'Sildesluk', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (33, 2, 8, 9, '2002-05-26', 213, 0, 'Sildesluk', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (34, 2, 22, 10, '2001-08-05', 200, 0, 'Meite', 'jeg er blitt mer og mer internettnerd! jeg peilet meg inn på en side som het fiskefeber!! tok kontakt med karra som dreiv siden og søkte etter nye plasser i oslofjorden. jeg og simen skulle ut å fiske denne uka og da gutta fra fiskefeber anbefalte denne p', 1);
INSERT INTO fangst VALUES (35, 2, 16, 8, '2002-07-01', 1025, 0, 'Hekle', 'Mangler', 1);
INSERT INTO fangst VALUES (36, 2, 20, 8, '2001-07-27', 150, 0, 'Meite', 'en artig tur ut med båten på grønnøy mitt på natta endte med ny rekord for meg. lusuer- en stygg en liten ufisk. hyggelig ferie med mange nye rekorder for draugen.ps! vi fikk også med oss fiskerinyhetene,et must for alle sportsfiskere- gammel som ung-.', 1);
INSERT INTO fangst VALUES (37, 2, 15, 11, '2001-11-12', 400, 0, 'Meite med makrell', 'Mangler', 1);
INSERT INTO fangst VALUES (38, 2, 12, 47, '2002-02-06', 325, 0, 'Mark og dupp', 'Mangler, Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (39, 2, 14, 9, '2001-05-20', 1100, 0, 'Sildesluk', 'Mangler, Rambergdypet.', 1);
INSERT INTO fangst VALUES (40, 2, 8, 8, '2001-07-25', 2300, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (41, 2, 25, 8, '2002-07-23', 1250, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (42, 2, 13, 13, '2002-08-11', 80, 0, 'Bollemeite', 'Mangler', 1);
INSERT INTO fangst VALUES (278, 25, 133, 36, '2006-06-25', 480, 0, 'Reke', 'Denne fisken tok jeg 15 minutter etter forrige. Vurderte å ta den med hjem for nermere undersøkelser, men siden den var peise lik første flire som jeg fikk gode bilder av, forkastet jeg dette. Flira trynet i grusen, men jeg fant ut at et grusete bilde ikke er grunn nok til å gruse denne persen.', 1);
INSERT INTO fangst VALUES (44, 2, 19, 8, '2002-07-02', 525, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (45, 25, 24, 15, '2002-06-12', 375, 0, 'Bunnmeite med sild', 'en herskare av nordea-ansatte kom nermere og nermere. til slutt sto de og gaula sanger ca 20m fra oss. idet vi skulle starte pakkinga for hjemreise, hvinte snella og monsteret var et faktum. etter en lang kamp på over 20 sek kunde jeg stolt lande denne fl, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (46, 25, 23, 16, '2001-11-03', 200, 0, 'Makrellagn på bunnen', 'Mangler', 1);
INSERT INTO fangst VALUES (47, 25, 17, 8, '2002-07-01', 260, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (48, 25, 22, 9, '2001-09-06', 775, 0, 'Stingsild langs bunnen', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (49, 25, 20, 8, '2001-07-24', 200, 0, 'Makrellagn', 'Mangler', 1);
INSERT INTO fangst VALUES (50, 25, 16, 8, '2002-07-01', 1050, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (51, 25, 15, 10, '2001-11-06', 375, 0, 'Meitefiske med makrell', 'tja, mista en hvitting som var dobbelt så stor, et par dager senere', 1);
INSERT INTO fangst VALUES (52, 25, 21, 8, '2001-07-25', 700, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (53, 25, 10, 47, '2002-03-30', 175, 0, 'Mormyska med brum (gammel) maggot', 'etter anvisning fra svigermor angående fiskeplass, dro jeg denne ruggen, Gammelhøttvika', 1);
INSERT INTO fangst VALUES (54, 25, 25, 8, '2002-07-01', 1050, 0, 'Stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (55, 25, 19, 8, '2002-07-01', 1650, 0, 'Makrellagn', 'Mangler', 1);
INSERT INTO fangst VALUES (56, 25, 14, 18, '2002-07-30', 600, 0, 'Stingsild', 'mye klaffet på denne nydelige dagen da jeg tok med thomas ut i min barndoms verden. jeg fikk denne pluss 2 kraftige napp. thomas? han kjente dessverre ingenting', 1);
INSERT INTO fangst VALUES (57, 25, 9, 47, '2002-03-29', 150, 0, 'Mormyska med brun (gammel) maggot', 'Mangler, Gammelhøttvika', 1);
INSERT INTO fangst VALUES (58, 25, 11, 19, '2001-08-15', 250, 0, 'Sølvkroken spesial', 'etter en absolutt forferdelig teltnatt, våknet jeg til sol og ørret!', 1);
INSERT INTO fangst VALUES (59, 25, 13, 13, '2002-08-11', 30, 0, 'Liiten krok med bolle', 'Mangler', 1);
INSERT INTO fangst VALUES (60, 25, 18, 8, '2002-07-01', 1025, 0, 'Rød stingsild', 'Mangler', 1);
INSERT INTO fangst VALUES (61, 25, 28, 47, '2002-03-29', 70, 0, 'Mormyska med brum (gammel) maggot', 'Mangler, Gammelhøttvika', 1);
INSERT INTO fangst VALUES (62, 25, 25, 9, '2003-07-18', 1450, 0, 'Makrellagn på bunnen', 'Mangler, Fredvikberget.', 1);
INSERT INTO fangst VALUES (63, 25, 10, 47, '2004-02-22', 100, 0, 'Pilk med maggot', 'Mangler, Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (64, 25, 11, 22, '2003-09-30', 220, 0, 'Sølvkroken spesial', 'Mangler', 1);
INSERT INTO fangst VALUES (65, 25, 24, 9, '2003-07-18', 270, 0, 'Makrellagn på bunnen', 'Mangler, Fredvikberget.', 1);
INSERT INTO fangst VALUES (67, 2, 8, 9, '2004-04-17', 600, 0, 'Mangler', 'Mangler, Fredvikberget.', 1);
INSERT INTO fangst VALUES (68, 2, 8, 9, '2004-04-17', 1600, 0, 'Mangler', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (69, 25, 8, 9, '2004-04-17', 500, 0, 'Mangler', 'Mangler, Rambergberget.', 1);
INSERT INTO fangst VALUES (70, 25, 8, 9, '2004-04-17', 1600, 0, 'Mangler', 'Mangler, Rambergodden.', 1);
INSERT INTO fangst VALUES (71, 9, 24, 15, '2004-04-24', 230, 260, 'Bunnagn med tre kroker: to med sild og en med reke', 'Odas første fisketur., Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (72, 9, 124, 15, '2004-04-24', 550, 380, 'Bunnmeite med reke', 'Odas første fisketur. En gjeng med unger fungerte som nappindikator., Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (73, 25, 8, 9, '2004-04-28', 400, 0, 'Bunnmeite med sild, gammel sild og reke', 'Mangler, Rambergdypet.', 1);
INSERT INTO fangst VALUES (80, 7, 124, 25, '2004-04-28', 380, 0, 'Mangler', 'Mangler', 1);
INSERT INTO fangst VALUES (81, 2, 24, 15, '2004-02-05', 420, 350, 'meite med oppheng', 'Jeg, Simen, Lene, Oda, Janne, Mina og Sickan var ute 1230 på denne nydelige søndagen.Vi fikk stanga ut i vika ganske fort da fjæra akkurat hadde vært på bunn (ca1100). Da Lene skulle dra i 3 tia fulgte Simen henne til båten. De var ikke kommet 70 meter fra standplass da jeg dro opp rekorden...  fiiiin dag, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (82, 7, 8, 15, '2004-05-02', 640, 0, 'Mangler', 'Mangler, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (84, 7, 17, 26, '2004-05-16', 285, 0, 'Mangler', 'Mangler', 1);
INSERT INTO fangst VALUES (85, 2, 17, 26, '2004-05-16', 270, 0, 'Mangler', 'Mangler', 1);
INSERT INTO fangst VALUES (86, 9, 10, 31, '2004-05-30', 340, 0, 'slukfiske i overflaten', 'Mangler', 1);
INSERT INTO fangst VALUES (87, 25, 126, 31, '2004-05-29', 65, 0, 'Kroket i siden da sluken var på vei ned', 'Mangler', 1);
INSERT INTO fangst VALUES (88, 2, 24, 15, '2004-06-23', 425, 0, 'Makrellagnpå bunnen', 'Mangler, Håkberget., Fredvikodden.', 1);
INSERT INTO fangst VALUES (89, 25, 12, 47, '2004-06-30', 240, 320, 'Svart 4-grams spesial med flueoppheng og markopphe', 'Sto i båten og kikka på fisken på høttgrunna. Med spesialbriller, blikkstille vann og sola i ryggen, ser man mye på 1-3 meters dyp. Siken jeg så gikk etter flua, men mista interessen. Så også en pen abbor. Da det ble stille kaste jeg på noen vak. Fikk siken med langsom fisking ved bunnen., Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (90, 25, 11, 34, '2004-07-07', 220, 0, '10-grams kulesøkke med mark en halvmeter bak. Ble', 'En hastetur med Håkon. Håkon skulle på kveldsvakt så vi hadde bare en times fiske til rådighet. Brukte 1 time opp og en halv time ned. Maksfart 55,5 km/t. Ca 15 km fra Tønsberggata 5.', 0);
INSERT INTO fangst VALUES (91, 25, 126, 8, '2004-07-13', 210, 0, 'sluk', 'Mangler', 1);
INSERT INTO fangst VALUES (92, 10, 20, 8, '2004-07-13', 210, 0, 'jukse', 'Mangler', 1);
INSERT INTO fangst VALUES (93, 9, 126, 8, '2004-07-20', 340, 0, 'Jukse', 'Mangler', 1);
INSERT INTO fangst VALUES (94, 2, 15, 29, '2004-07-14', 600, 0, 'pilk på 180 m', 'Mangler', 1);
INSERT INTO fangst VALUES (95, 25, 15, 8, '2004-07-20', 700, 0, 'Svenskpilk 250g på 80 m,', 'Mangler, Jektvikbøya.', 1);
INSERT INTO fangst VALUES (96, 25, 8, 29, '2004-07-15', 9000, 1005, 'Pilk på 80 m. I en pen seistim.', 'Hadde tenkt meg ned på 200 meter med svenskpilken. På 80 meter stoppet den og den dro ut en del snøre. Fikk etterhvert starta oppsveivinga. Ble med ett lettere da torsken svømte inn i andre snører fra båten. Fikk hjelp fra ca 50 meter og opp. På samme snøre fikk jeg en sei på 3,5 kg. Det var et fint skue da den kom opp; Snørevaser uten like, multifilament og tjukk nylon med 4-8 kroker i bunnen av båten sammen med torsk på 9 og sei på 3,5.', 1);
INSERT INTO fangst VALUES (97, 25, 125, 29, '2004-07-13', 1725, 0, 'Pilk på 180 m.', 'Antar at jeg hadde 180 til 200 meter snøre på snelle. Målet var å dunke pilken i bunnen før jeg begynte å fiske etter Ueren. Jeg nådde aldri bunnen og hadde ca 3-4 meter snøre igjen på snella da fisken bet på. Artige minutter ved oppsveivingen av denne fisken. Spennende når det biter på nesten 200 meter. Jeg ble ikke skuffet.', 1);
INSERT INTO fangst VALUES (98, 11, 25, 29, '2004-07-12', 4000, 0, 'Jukse', 'Mangler', 1);
INSERT INTO fangst VALUES (99, 25, 25, 29, '2004-07-15', 3500, 0, 'Gummimakk på 80 m.', 'Dro en del sei på denne turen til Grønøy. Dette var den største. Bet på gummimakken 1 meter over svenskpilken. På svenskpilken satt en torsk på 9 kg.', 1);
INSERT INTO fangst VALUES (100, 11, 16, 29, '2004-07-13', 2000, 0, 'Jukse', 'Mangler', 1);
INSERT INTO fangst VALUES (101, 11, 8, 8, '2004-07-15', 4100, 0, 'Jukse', 'Mangler', 1);
INSERT INTO fangst VALUES (105, 10, 126, 8, '2004-07-13', 250, 0, 'Jukse', '', 1);
INSERT INTO fangst VALUES (107, 12, 8, 8, '2004-07-12', 2000, 0, 'Jukse', '', 1);
INSERT INTO fangst VALUES (108, 9, 15, 8, '2004-07-20', 200, 0, 'Jukse med sildeagn', ', Grønøystilla', 1);
INSERT INTO fangst VALUES (109, 2, 25, 29, '2004-07-12', 3750, 0, 'Pilk', '', 1);
INSERT INTO fangst VALUES (110, 12, 25, 29, '2004-07-12', 3500, 0, 'Jukse', '', 1);
INSERT INTO fangst VALUES (111, 12, 10, 35, '2003-05-10', 650, 450, 'Sildesluk', '', 1);
INSERT INTO fangst VALUES (112, 26, 8, 15, '2004-06-23', 400, 0, 'Sildesluk', ', Håkberget., Fredvikodden.', 1);
INSERT INTO fangst VALUES (113, 25, 127, 34, '2004-09-02', 105, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (114, 25, 10, 34, '2004-09-02', 220, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (115, 2, 127, 34, '2004-09-02', 125, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (117, 2, 128, 35, '2004-08-08', 560, 0, 'tobis', '', 1);
INSERT INTO fangst VALUES (118, 12, 129, 31, '2003-05-29', 250, 0, 'Hekle med agnsild', '', 1);
INSERT INTO fangst VALUES (119, 2, 8, 8, '2004-07-15', 2200, 0, 'Pilk', '', 1);
INSERT INTO fangst VALUES (120, 25, 20, 8, '2004-07-15', 130, 0, 'Pilk', '', 1);
INSERT INTO fangst VALUES (121, 2, 20, 8, '2004-07-15', 130, 0, 'Pilk', '', 1);
INSERT INTO fangst VALUES (122, 25, 16, 29, '2004-07-15', 900, 0, 'Svenskpilk, 250g', '', 1);
INSERT INTO fangst VALUES (123, 2, 11, 34, '2004-02-09', 90, 0, 'Spinner', '', 1);
INSERT INTO fangst VALUES (124, 2, 10, 34, '2004-09-02', 80, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (125, 2, 10, 47, '2002-02-06', 100, 0, 'Mark', ', Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (126, 25, 130, 36, '2004-09-12', 230, 0, 'Sølvkroken spesial kobber', '', 1);
INSERT INTO fangst VALUES (127, 25, 131, 36, '2004-09-12', 780, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (128, 25, 128, 36, '2004-09-12', 260, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (129, 2, 131, 36, '2004-09-12', 1000, 0, 'Mark og dupp', '', 1);
INSERT INTO fangst VALUES (130, 2, 10, 36, '2004-09-12', 120, 0, 'Mark og dupp', '', 1);
INSERT INTO fangst VALUES (131, 7, 131, 36, '2004-09-12', 180, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (132, 2, 11, 37, '2004-09-28', 160, 26, 'Mark', '', 1);
INSERT INTO fangst VALUES (133, 2, 132, 38, '2004-10-12', 1660, 0, 'Monsterwobbler', ', Rælingsbrua.', 1);
INSERT INTO fangst VALUES (134, 2, 132, 38, '2004-10-17', 1720, 0, 'Monsterwobbler', ', Rælingsbrua.', 1);
INSERT INTO fangst VALUES (135, 2, 21, 10, '2004-10-24', 1550, 0, 'Sildesluk', '', 1);
INSERT INTO fangst VALUES (137, 25, 21, 26, '2004-11-14', 130, 0, 'Makrellagn på bunnen', '', 1);
INSERT INTO fangst VALUES (138, 2, 124, 26, '2004-11-14', 490, 0, 'Makrellagn på bunnen', '', 1);
INSERT INTO fangst VALUES (139, 12, 21, 26, '2004-11-14', 70, 0, 'Stingsild', '', 1);
INSERT INTO fangst VALUES (140, 25, 24, 15, '2005-01-23', 240, 285, 'blekksprut/blåskjell-agn', ', Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (141, 2, 28, 47, '2005-01-30', 75, 250, 'røyeblink', ', Rønneberget', 1);
INSERT INTO fangst VALUES (142, 27, 8, 40, '2005-02-20', 420, 0, 'Jukse', '', 1);
INSERT INTO fangst VALUES (143, 27, 15, 40, '2005-02-20', 200, 0, 'Jukse', '', 1);
INSERT INTO fangst VALUES (144, 25, 8, 15, '2005-04-03', 1000, 0, 'Jig - børstemark', 'Årets første fangst!, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (145, 2, 24, 15, '2005-04-03', 240, 0, 'agn-blåskjell', 'Årets første!!, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (146, 2, 8, 15, '2005-04-03', 600, 0, 'agn-blåskjell', 'kjedelig fangst ass\r\n, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (147, 27, 24, 15, '2005-04-17', 460, 330, 'Blåskjell med møresild som søkke', 'Tror Thomas hadde glemt to gram her...\r\nC-A, Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (148, 25, 24, 15, '2005-04-17', 270, 0, 'Blåskjellagn', 'Etter 20 turer på denne plassen, ble Maja med denne gangen. jeg dro denne sandflyndra rett før Maja fiksa ny Draugen-rekord på sandflyndre 460 gr. Ellers mista jeg mobilen da jeg satte ut sandflyndra mi. Den ligger nå på 4 meters dyp ved odden. Maja falt i vannet. Vi vridde opp klær og jogge til båten som heldigvis var på vei., Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (149, 2, 8, 15, '2005-04-17', 710, 0, 'Blåskjellagn med blekksprut', ', Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (150, 25, 131, 38, '2005-04-21', 1400, 0, 'Mark på bunnen', 'Denne var rekord i en time eller noe slikt før thomas slo den med en på 1,6 for deretter å klinke til med 2,15!, Rælingsbrua.', 1);
INSERT INTO fangst VALUES (151, 25, 127, 38, '2005-04-21', 160, 235, 'Mark på bunnen', 'Hadde landet et par gjedder og noen brasmer da det under kaffen begynte å rykke i stanga. -Nå kunne jeg tenkt meg en oversized mort sa jeg og gikk for å trekke opp. Joda. Mort., Rælingsbrua.', 1);
INSERT INTO fangst VALUES (152, 25, 132, 38, '2005-04-21', 1450, 610, 'Mark på bunnen', ', Rælingsbrua.', 1);
INSERT INTO fangst VALUES (153, 2, 131, 38, '2005-04-21', 2150, 555, 'Mark på bunnen', ', Rælingsbrua.', 1);
INSERT INTO fangst VALUES (154, 2, 24, 15, '2005-04-26', 360, 0, 'Blåskjell', ', Fredvikodden., Fredvikodden.', 1);
INSERT INTO fangst VALUES (155, 28, 133, 41, '2005-04-30', 200, 0, 'Mark på bunnen', '', 1);
INSERT INTO fangst VALUES (156, 2, 133, 41, '2005-04-30', 120, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (157, 2, 128, 41, '2005-04-30', 220, 0, 'Mark', '', 1);
INSERT INTO fangst VALUES (158, 2, 134, 9, '2005-05-05', 450, 710, 'Dupp med sild', ', Rambergodden.', 1);
INSERT INTO fangst VALUES (159, 25, 8, 9, '2005-05-12', 750, 0, 'Rød stingsild', 'Må legge inn denne for å få fortelle at jeg hadde 4 napp av horngjel. Nermeste kom 3 meter fra Thomas'' kyndige håvhender., Rambergodden.', 1);
INSERT INTO fangst VALUES (160, 2, 25, 15, '2005-05-12', 1300, 590, 'rekeagn', 'morsomt å få en ganske stor sei for Oslofjorden og være og i tilegg på rekeagn...  nydelig dag, Håkberget., Fredvikodden.', 1);
INSERT INTO fangst VALUES (161, 25, 12, 47, '2005-05-15', 160, 310, 'Mark og dupp', 'En relativ skral helg i forhold til Arctanders fangster., Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (162, 2, 12, 47, '2005-05-14', 270, 340, 'mark og dupp', ', Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (163, 2, 11, 47, '2005-05-14', 240, 316, 'mark og dupp', ', Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (164, 2, 10, 47, '2005-05-15', 80, 0, 'Mark og dupp', ', Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (165, 25, 8, 42, '2005-05-22', 1040, 0, 'Blåskjell på bunnen', 'Slo gammel årspers med 40 gram. Noe leit at torsken raste avgårde med det lille blåskjellet jeg hadde.', 1);
INSERT INTO fangst VALUES (166, 25, 24, 9, '2005-05-30', 290, 315, 'Reke på bunnen', 'Sandflyndra kom rett før vi skulle dra. Vi ble nødt til å løpe over hele Rambergøya deretter Gressholmen for å rekke siste båt kl 2340., Rambergberget.', 1);
INSERT INTO fangst VALUES (167, 25, 134, 9, '2005-05-30', 530, 740, 'Sildedupp', 'Hadde akkurat vært full fjære da vi kom til odden. Fikk kasta ut sildeduppen med 2 pene stykker sild under. Horngjelen bet på temmelig kjapt. Fikk mange flere Horngjel de nermeste timene, men ingen som kom opp mot dennes vekt., Rambergodden.', 1);
INSERT INTO fangst VALUES (168, 2, 14, 9, '2005-05-30', 1180, 495, 'sluk-tobis', ', Rambergodden.', 1);
INSERT INTO fangst VALUES (169, 25, 11, 47, '2005-06-04', 80, 0, 'Mark og dupp', 'Eneste ørrret denne helga. Har aldri fått mindre på Myllhøttgrunna., Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (170, 25, 10, 47, '2005-06-04', 140, 235, 'Mark og dupp', 'Dro 16 abbor denne helga. Det finnes nok større abbor her, men man må kanskje benytte andre metoder., Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (171, 2, 22, 26, '2005-06-12', 410, 370, 'sildesluk', 'Morsomt med årets første makrell.Dumt var det at jeg mista seien min på rundt 1.5-2.0 kg... Nå må jeg kjøpe meg hov.Kan jo ikke stole på at Simen er med vær tur.', 1);
INSERT INTO fangst VALUES (172, 7, 22, 26, '2005-06-12', 210, 300, 'sildesluk', '', 1);
INSERT INTO fangst VALUES (173, 25, 8, 9, '2005-06-15', 1400, 600, 'Mørsesilda, svart og sølv', 'Torsken bet som rakkern her ute i dag. Etter at jeg dro opp en torsk på nermere 2 kg, som ikke ble godkjent p.g.a. kroking på oversiden av hodet, måtte jeg prøve torskefisket. Hadde håpet på en slenger av knurr, men det ble bare torsk ca 10 stykker., Rambergodden.', 0);
INSERT INTO fangst VALUES (174, 25, 22, 9, '2005-06-15', 350, 355, 'Sildesluk', 'Tatt i betraktning at dette ble turens eneste makrell må jeg si meg fornøyd. Hadde likevel håpet på noe større makrell i dag., Rambergodden.', 1);
INSERT INTO fangst VALUES (175, 25, 11, 43, '2005-06-19', 60, 0, 'Mark og dupp', 'Maja hadde svært lyst å fiske. Oda,  Julia og jeg befant oss på Bjølsen, så CA og Maja kom dit. De hadde med 2 stenger. Vi fant kom oss ut på øya rett nedenfor brua ved Janne. Gravde litt mark og Oda vassa litt i vannet. Jeg prøvde ett kast og landet denne ørreten på ca 60 gram. Jeg veide den ikke.', 1);
INSERT INTO fangst VALUES (176, 2, 14, 9, '2005-06-15', 1700, 530, 'makrelldupp', 'morsomt å få en s.ø på dupp. har jo hørt at dette skal kunne gjøres men aldri opplevd det selv. Det kjipe var at rett etterpå hadde jeg på en stooor s.ø på tobis men den glapp da den la seg i ett byks opp i vannflata.. artig tur, Rambergodden.', 1);
INSERT INTO fangst VALUES (177, 2, 135, 36, '2005-06-19', 330, 360, 'møresild', 'ikke så stor men ny art er jo alltid morsomt... jippi.', 1);
INSERT INTO fangst VALUES (178, 25, 10, 22, '2005-06-21', 160, 250, 'Mark og dupp', 'Catcha 4 abbor på denne turen. Den største var 160g og ny årspers. Fikk så vidt prøvd bunnmeite med mark. 3x0,8g søkke. Virket særdeles effektivt på denne turen. Fikk bare prøvd det ca 10 min, men hadde ett napp og fikk 2 abbor på det. Ørreten merka jeg ingenting til. Thomas hadde så og si en 300+ grams ørret, men den sleipa seg ut av hendene hans da han prøvde å lande den.', 1);
INSERT INTO fangst VALUES (179, 25, 12, 47, '2005-06-25', 250, 325, 'Mark med 2,4 g søkke', 'Sto i båten og kastes mark med 3 blysøkker for kastevekt. Dro marken sakte inn og da satt denne Siken., Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (180, 25, 11, 23, '2005-06-25', 340, 315, 'Sølvkroken spesial kobber og rød, 7grams.', 'Etter å ha fått 3 abborer i størrelsen 100 til 140 gram på 3 kast ble det stille. Det var stille i ca. ett kvarter til denne ørreten plutselig satt på kroken.', 1);
INSERT INTO fangst VALUES (181, 25, 10, 47, '2005-06-25', 400, 315, 'Mark med 2,4 g søkke', 'Drev å sjekka ut hvordan en abbor på ca 120 gram reagerer på forskjellige bevegleser av marken. Jeg sto i båten på grunna med polariserende briller og sol på hodet. Så bunnen temmelig godt. Jeg fikk prøvd noen forskjellige bevegleser uten å finne noen klar favoritt da denne abboren på 400 gram dukket opp. Jeg skvatt til og dro marken med jevn beveglese framover. Storingen svømte etter og slukte marken. Kåla litt med enmannshåving, men redde fisken opp i båten etter kort stund., Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (182, 25, 128, 44, '2005-06-29', 610, 365, 'Flytebrød', 'Hekta loff på relativt stor krok og lot den seile ned elva. Denne buken nappa flere ganger før den tok. Fikk forøvrig også en noe mindre buk.', 1);
INSERT INTO fangst VALUES (183, 25, 136, 44, '2005-06-29', 1440, 495, 'Flytebrød', 'Hekta på loff og lot den seile nedover elva. Jeg så denne stamen var oppe flere ganger og snuste på brødet (Man ser ryggfinnen på den), før den slukte. Kraftig fisk.', 1);
INSERT INTO fangst VALUES (184, 25, 137, 23, '2005-07-03', 5, 87, 'mark', 'Gadd ikke vente leger på art nr. 30.', 1);
INSERT INTO fangst VALUES (185, 28, 10, 47, '2005-07-03', 44, 165, 'Makk med søkke', 'Ute på an behagelig rotur fra Myllebråtan mot Svarttangen. Rodde inn vika øst for Svarttangen mens vi dorga med stang og makkangel. Etter å ha kommet ut av vika øst for Svarttangen og satt kursen lenger øst lå vi i ro og svevde på de 1 cm høye bølgene. Etter kort tid kjente jeg det kilte mellom ringene på teleskopstanga og det var bare å sveive inn min første abbor i Draugen., Svarttangen', 1);
INSERT INTO fangst VALUES (186, 25, 26, 46, '2005-07-09', 40, 150, 'Nytrukket makrellbit på liten krok', 'Lurte litt på bergnebbstørrelser, men nå kan jeg slå fast at min gamle rekord på bergnebb er temmelig riktig veid.', 1);
INSERT INTO fangst VALUES (187, 25, 16, 46, '2005-07-10', 1370, 500, 'En reke over svenskpilk', 'Min første fangst på ny havfiskesnelle. Fungerte utmerket for å heise denne pene hysa opp fra 65 meters dyp. Hysa bet på bunnen etter noe lokking.', 1);
INSERT INTO fangst VALUES (188, 25, 25, 46, '2005-07-09', 600, 390, 'Reke rett over bunnen', 'Denne seien ble kroka på 20 meters dyp. Min første sei i år. Dette er faktisk den egentlig første fisken på ny havsnelle.', 1);
INSERT INTO fangst VALUES (189, 25, 21, 46, '2005-07-10', 500, 400, 'Dorging men sildesluk', 'Men min flaue pers på lyr består. Fornøyd med å få lyr, men Jarle landa en på 1 kg litt tidligere på kvelden. Temmelig mørkt.', 1);
INSERT INTO fangst VALUES (190, 9, 11, 47, '2005-07-16', 260, 310, 'Dorging med wobbler', ', Mylla', 1);
INSERT INTO fangst VALUES (191, 25, 11, 47, '2005-07-16', 475, 360, 'Dorging med wobbler', 'Plutselig slo alt til på Mylla. I løpet av 2 dager fikk jeg 16 ørret. Snittstørrelse på ca 280 gram, Mylla', 1);
INSERT INTO fangst VALUES (192, 25, 22, 29, '2005-07-20', 725, 0, 'Møresilda', 'Etterlengtet fin fangst på Grønøy etter tildels svart hav. Ute på bergene med Lene, Ingri og Leif-Atle. Glimrende som agn til skatefisket senere i dag.', 1);
INSERT INTO fangst VALUES (193, 25, 8, 8, '2005-07-21', 2450, 660, 'Makrellagn', 'Håper på større torsk på dette oppholdet.', 1);
INSERT INTO fangst VALUES (194, 25, 20, 8, '2005-07-21', 140, 210, 'Stingsild', 'Den obligatoriske lusueren er tatt for min del. Har liten tro på at det finnes noen eksemplarer her som er særlig større enn 200 gram.', 1);
INSERT INTO fangst VALUES (195, 25, 16, 29, '2005-07-21', 2075, 610, 'Makrellagn', 'Pen hyse. Er temmelig sikker på at jeg hadde en 3-kiloshyse på før denne kom.', 1);
INSERT INTO fangst VALUES (198, 30, 16, 8, '2005-07-21', 800, 0, 'Stingsild', '', 1);
INSERT INTO fangst VALUES (199, 30, 25, 8, '2005-07-21', 400, 0, 'Stingsild', '', 1);
INSERT INTO fangst VALUES (200, 25, 28, 48, '2005-07-22', 100, 220, 'Dorging med wobler', '', 1);
INSERT INTO fangst VALUES (201, 25, 138, 8, '2005-07-22', 1410, 520, 'Makrellagn på bunnen', 'Når det biter på makrellagn på bunnen er det 95% sikkert torsk, sa jeg og så fikk jeg øye på vidunderet. Håva den forsiktig, klipte snøret og dunka den i hodet. Mulig hodedunking er noe ineffektivt på steinbit for det var noe sprelling etterpå i bøtta. Vi holdt oss langt unna bøtta på resten av båtturen. Skjelving i knærne ga seg da vi kom i land.', 1);
INSERT INTO fangst VALUES (202, 11, 20, 8, '2005-07-25', 220, 140, 'Jukse', 'Et platå mellom fyrtårnet og Kirkhelleren på ca. 30m dyp. Tatt på full flo ca. 01:30. ', 1);
INSERT INTO fangst VALUES (203, 11, 8, 8, '2005-07-25', 3450, 0, 'Jukse', 'Platået mellom fyrtårn og Kirkhelleren ca. kl 01:30 på full flo.', 1);
INSERT INTO fangst VALUES (204, 25, 139, 49, '2005-07-24', 2000, 600, 'Reke på bunnen', 'Slapp bommen ned på 215 meters dyp. Etter noe sleping bet denne brosmen på reka. Havet var forøvrig fullt av brosmeegg.', 1);
INSERT INTO fangst VALUES (205, 2, 25, 29, '2005-07-26', 2800, 0, 'Havfiskebom med pilk', 'Grei sei', 1);
INSERT INTO fangst VALUES (206, 10, 11, 48, '2005-07-22', 150, 0, 'Min nye guidelinestang', 'Første fisk på stanga mi! Hurra! Også min første ørret i draguentid. Det var stort. Fangsten oppnådde jeg ved dorging på Skarsvatnet på Åmøya. Takk til Simen og Leif Atle for utmerket roing!:)', 1);
INSERT INTO fangst VALUES (207, 9, 11, 47, '2005-08-05', 340, 0, 'Wobler', 'Dorginh, Mylla', 1);
INSERT INTO fangst VALUES (208, 2, 128, 44, '2005-08-11', 1570, 480, 'flytebrød', '', 1);
INSERT INTO fangst VALUES (210, 37, 130, 36, '2005-08-11', 1630, 0, 'Tobis', '', 1);
INSERT INTO fangst VALUES (211, 25, 10, 50, '2005-09-03', 490, 310, 'Mark', 'Fin glede over denne abboren, men det store målet, karuss, fikk vi ikke kjenning med.', 1);
INSERT INTO fangst VALUES (212, 2, 10, 50, '2005-09-03', 410, 300, 'makk', '', 1);
INSERT INTO fangst VALUES (213, 25, 10, 51, '2006-01-08', 250, 250, 'Pimpel med maggot', 'Kasta oss med på isfiskekonkurranse. Jeg fikk totalt 1230 gram abbor fordelt på ca 15 stykker. Vinneren landa 3 kg. Jeg tror han fuska.', 1);
INSERT INTO fangst VALUES (214, 2, 132, 51, '2006-01-08', 500, 400, 'pimpel', 'Første gjedde på isen!!! det var skummelt altså!', 1);
INSERT INTO fangst VALUES (215, 25, 127, 52, '2006-01-15', 190, 0, 'Mormyska', 'Første morten på isen var også den største. Fikk ca 5-6 mort til sammen denne dagen.', 1);
INSERT INTO fangst VALUES (216, 2, 127, 52, '2006-01-15', 140, 25, 'pimpel/hvit maggot', '10 mort i rask rekkefølge og ca 15 totalt.. morsomt!!', 1);
INSERT INTO fangst VALUES (217, 35, 127, 52, '2006-01-15', 130, 20, 'pimpel m/ maggot', 'Første fisk, men ikke siste fisk i Draugen...', 1);
INSERT INTO fangst VALUES (218, 35, 10, 51, '2006-01-08', 100, 150, 'mormyshka', '', 1);
INSERT INTO fangst VALUES (219, 25, 140, 53, '2006-02-19', 60, 0, 'Reke på bunnen', 'God appetitt på piken', 1);
INSERT INTO fangst VALUES (220, 25, 15, 53, '2006-02-19', 685, 0, 'Reke på bunnen', 'Fisket starta fint og fiskene ble større og større i et par timer. Deretter dabbet det av.', 1);
INSERT INTO fangst VALUES (221, 25, 8, 54, '2006-03-31', 3160, 0, 'Rekeagn', 'Dagen startet bra med denne pene torsken på isen, Oldereid.', 1);
INSERT INTO fangst VALUES (222, 25, 18, 54, '2006-03-31', 880, 0, 'Rekeagn', 'Bet på ca 18 meters dyp. Første fisk som ble dratt opp på isen denne dagen., Oldereid.', 1);
INSERT INTO fangst VALUES (223, 25, 16, 54, '2006-04-01', 2980, 0, 'Halv makrellfilet', 'Makrellfileten ble større og større denne natta. En halv makrellfilet dinglende en meter over bunnen ga denne pene hysa., Oldereid.', 1);
INSERT INTO fangst VALUES (224, 25, 8, 54, '2006-04-01', 13750, 1160, 'Hel makrellfilet', 'Etter jeg satte på hel makrellfilet, bet denne torsken over stasen. Jeg ropte etter motorsag for utvidelese av hullet før jeg hadde sett fisken (en stor sjanse og ta). Hullet ble borret opp, kleppen knakk, og thomas tok tak i leppa og røska Torsken opp fra hullet. Etter nærmere inspeksjon gikk det opp for meg at fisker på en slik størrelse neppe har problemer med å dundre i seg agn som er mye større enn en makrellfilet., Oldereid.', 1);
INSERT INTO fangst VALUES (225, 2, 8, 54, '2006-03-31', 2540, 0, 'agn', 'årets siste torsk.., Oldereid.', 1);
INSERT INTO fangst VALUES (226, 2, 18, 54, '2006-03-31', 1590, 0, 'agn', 'kveita var sterkere en jeg hade trodd.. ble veldig glad for denne.., Oldereid.', 1);
INSERT INTO fangst VALUES (227, 2, 8, 54, '2006-04-01', 2120, 0, 'agn', 'årets første.. dette blir ett innholdsrikt år.., Oldereid.', 1);
INSERT INTO fangst VALUES (228, 2, 16, 54, '2006-04-01', 650, 0, 'stingsild med opphenger', 'muligens eneste/største hyse i år siden det ikke blir flere turer til nordnorge.., Oldereid.', 1);
INSERT INTO fangst VALUES (229, 38, 8, 54, '2006-03-31', 6850, 0, 'agn', 'mortens første pers i draugen og draugens andre største fisk.., Oldereid.', 1);
INSERT INTO fangst VALUES (230, 38, 16, 54, '2006-04-01', 230, 0, 'agn', 'ikke den største på turen men verdt å ha med, Oldereid.', 1);
INSERT INTO fangst VALUES (231, 7, 16, 0, '2005-03-31', 1580, 0, 'stang med reke', '', 0);
INSERT INTO fangst VALUES (232, 7, 18, 0, '2005-03-31', 1220, 0, 'stang med reke', '', 0);
INSERT INTO fangst VALUES (258, 25, 24, 56, '2006-04-10', 410, 330, 'Rekeagn', 'Fisken ble tatt på krok agnet med reke. Liten perle foran kroken. ca 80 cm 0,45 mm fortom festet i virvel til hovedsena. virvel delvis skjult av gummislange. Stangtuppen vippa så vidt,jeg sveiva inn sluken på den andre stanga og fikk deretter kroket denne flyndra som Thomas håvet utmerket.', 1);
INSERT INTO fangst VALUES (259, 2, 9, 47, '2006-04-13', 260, 0, 'glidende takkel med selvlysende perle og makrell', 'mylla overasker stadig.. tatt kl 23:30, Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (255, 7, 16, 54, '2006-03-31', 1580, 0, 'stang', 'agnet med reke, Oldereid.', 1);
INSERT INTO fangst VALUES (256, 7, 18, 54, '2006-03-31', 1220, 0, 'stang', 'Isfiske. Agnet med reke, Oldereid.', 1);
INSERT INTO fangst VALUES (260, 25, 10, 47, '2006-04-15', 110, 220, 'Balansepilk', 'Nappa opp et par abborer med pimpel. Tipper den største var 100 gram. Gikk over til balanse og dro denne abboren. Fisken bet rundt klokken 10., Mylla', 1);
INSERT INTO fangst VALUES (261, 2, 10, 47, '2006-04-13', 100, 0, 'balansepilk', 'napp på første nedsveiving...kaffen fløy da jeg uventet måtte dra opp dette beistet på hele 100gr!!!, Myllhøttgrunna', 1);
INSERT INTO fangst VALUES (262, 2, 128, 38, '2006-05-01', 1520, 0, 'glidende takkel med løkpølse', 'Noen kjappe bilder som ikke ble så bra for og artsbedømme. Ellers ble den rask satt ut igjen for å vokse seg feit. , Dynotarmen.', 1);
INSERT INTO fangst VALUES (263, 2, 24, 9, '2006-05-07', 330, 0, 'bunnmeite med blåskjell', 'fikk ei mindre sandflyndre og en torsk (ca 700gr) kom til fredvik etter blanking på rambergberget..fikk flyndra mitt mellom flo og fjære, Fredvikberget.', 1);
INSERT INTO fangst VALUES (264, 2, 127, 36, '2006-05-14', 190, 0, 'dupp og mark', '', 1);
INSERT INTO fangst VALUES (265, 2, 141, 36, '2006-05-14', 35, 0, 'dupp og mark', '', 1);
INSERT INTO fangst VALUES (266, 2, 142, 36, '2006-05-14', 40, 0, 'krok og mark', 'Denne blir fryst og brukt til agn senere etter gjørs.', 1);
INSERT INTO fangst VALUES (267, 39, 127, 36, '2006-05-14', 110, 0, 'bunnmeite med mark', 'Mina`s første fisk!!!! hurra!!', 1);
INSERT INTO fangst VALUES (268, 25, 134, 9, '2006-05-28', 220, 600, 'Sildesluk med flueoppheng', 'Hevet stemmen, kremtet og ba om håving fra Thomas. Så med en gang at denne tassen ikke var stor, men det var årets første Horngjel og den er ikke alltid like lett å få tak i. Gjelen tok på gul flue., Rambergodden.', 1);
INSERT INTO fangst VALUES (269, 25, 14, 9, '2006-05-28', 2090, 620, 'Makrelldupp med makrellfiletstrimmel', 'Det er en deilig følelse å se på duppen når den forsvinner for så å forbli under. Kroket denne saken fint, kjente at det var store greier, vurderte makrell, men antok at det var en større sjøørret. Som seg hør og bør antydet jeg for Thomas at dette sannsynligvis ikke var en 200-grams Horngjel. Thomas håvet fint og jeg kunne puste ut. Har nok ikke vært så redd siden Morten stod med motorsaga i samme hull som mitt snøre og en 13,75-kilos Torsk. Fikk ytterligere en Sjøørret noe senere. Den var i overkant av kiloet. Min første Sjøørret i Oslofjorden. Den kom sent, men vanvittig godt., Rambergodden.', 1);
INSERT INTO fangst VALUES (270, 7, 11, 47, '2006-05-27', 120, 0, 'stang m/wobbler', ', Mylla', 1);
INSERT INTO fangst VALUES (271, 7, 11, 47, '2006-05-28', 250, 0, 'stang m/wobbler', ', Mylla', 1);
INSERT INTO fangst VALUES (273, 2, 134, 9, '2006-05-28', 210, 0, 'opphenger på sildesluk', ', Rambergodden.', 1);
INSERT INTO fangst VALUES (274, 2, 135, 36, '2006-06-25', 1820, 610, 'bunnmeitet laue', 'fast fisk på 2 min... målrettet fiske på sitt beste!!!!', 1);
INSERT INTO fangst VALUES (275, 25, 131, 36, '2006-06-25', 950, 0, 'Mark', 'Pitteliten mark beregnet på laue knuste denne kjempen i land.', 1);
INSERT INTO fangst VALUES (276, 25, 135, 36, '2006-06-25', 670, 0, 'Reke', 'Fritthengende reke fikk denne Gjørsen til å snuble seg opp på land. Etter å ha blitt lei av å fange laue med minimark, kjørte jeg på en reke på en litt større krok.', 1);
INSERT INTO fangst VALUES (277, 25, 133, 36, '2006-06-25', 420, 0, 'Reke', 'Reke på friline slengt ut gjentatte ganger.', 1);
INSERT INTO fangst VALUES (279, 25, 22, 58, '2006-07-02', 210, 0, 'Blå Møresild med opphenger', 'Ute å kjørte smekker båt. Dorget denne på sammen med en litt mindre makrell på opphengeren. Ble tatt litt utenfor sundet mellom Lindøya og Rambergøya.', 1);
INSERT INTO fangst VALUES (280, 11, 126, 8, '2006-07-15', 250, 320, 'harpe', 'Tatt under grønøybrua', 1);
INSERT INTO fangst VALUES (281, 36, 25, 8, '2006-07-15', 130, 240, 'harpe', '', 1);
INSERT INTO fangst VALUES (282, 30, 25, 8, '2006-07-16', 915, 470, 'stang', 'Hoppa av kroken rett ved båtripa. Samme fisken bit på harpa rett etterpå...', 1);
INSERT INTO fangst VALUES (283, 30, 8, 8, '2006-04-30', 3500, 0, 'stang', 'For stor til å løfte opp i båten med stanga så bestefar leker klepp og løfter den etter gjellene.', 1);
INSERT INTO fangst VALUES (284, 11, 8, 8, '2006-07-16', 775, 490, 'harpe', '', 1);
INSERT INTO fangst VALUES (285, 11, 25, 8, '2006-07-16', 170, 265, 'harpe', '', 1);
INSERT INTO fangst VALUES (286, 25, 19, 59, '2006-07-19', 2000, 750, 'Seifilet', 'Langen ble tatt på ca 60 meters dyp og ca en kilometer vest for Reine, men før Djupfjorden. Fisken bet på et lite gjennomtenkt oppheng av seifilet over en Shadjigg.', 1);
INSERT INTO fangst VALUES (287, 25, 18, 8, '2006-07-21', 3300, 680, 'Rekeagn på bunnen', 'Det røsket til i stanga da denne beit på. Etter flere utras lå den stabilt ved brygga mens Rafael løp etter hoven et slukkast unna (som kråka flyr). Etter nok et utras mot bryggestolpen, fikk Bjørn håvet denne kveita og jeg pustet ut. Vel oppe på Einar-Erlend-brygga ble det tid til gratulasjoner og glede inntil jeg la merke til et hyl i retning kveita. Rafael skulle bare kjenne på tunga til kveita og sto nå med en blodig pekefinger i været. Etter sløying fikk Rafael kveithauet.', 1);
INSERT INTO fangst VALUES (288, 25, 22, 8, '2006-07-23', 900, 0, 'Møresilda, 28 gram', 'Fikk tid til en del kasting på Einar-Erlend-brygga før vi skulle dra sørover. Fikk totalt 4 makrell. Den første var den største.', 1);
INSERT INTO fangst VALUES (289, 30, 22, 8, '2006-07-22', 500, 0, 'Sluk', 'Makrellen ble tatt på Einar-Erlend-brygga sammen med bestefar.', 1);
INSERT INTO fangst VALUES (290, 40, 22, 8, '2006-07-21', 650, 0, 'Sildesluk', '', 1);
INSERT INTO fangst VALUES (291, 10, 22, 8, '2006-07-26', 570, 0, 'Stingsild på stang', '', 1);
INSERT INTO fangst VALUES (293, 2, 26, 25, '2006-08-02', 55, 0, 'reke', 'etter en lang og hard kamp med flere utras kunne jeg endelig håve denne storkær`n', 1);
INSERT INTO fangst VALUES (294, 25, 128, 44, '2006-08-03', 1370, 440, 'Flytebrød', 'Denne rakkeren bet i ca 22:30. Ingen stor kamp, men dog.', 1);
INSERT INTO fangst VALUES (295, 29, 28, 60, '2006-08-03', 275, 300, 'Spinner,rødmønstra droppen', 'Da va d jaggu på tide at æ fikk en draugrekord så æ kun vær me på morro æ og! Eller e d ikke sånn d e? Fant itj nå vedtekta,så har allti gått ut i fra d.. Men d føles iallefall bra! Bare æ får den godkjent no da..', 1);
INSERT INTO fangst VALUES (296, 2, 143, 62, '2006-08-06', 30, 0, 'Mais', 'Denne kjempen kom opp etter flere sørv i samme størrelse. Skal forbedres..', 1);
INSERT INTO fangst VALUES (297, 2, 144, 62, '2006-08-06', 30, 0, 'Mais', '', 1);
INSERT INTO fangst VALUES (298, 2, 145, 61, '2006-08-06', 60, 0, 'Bunnmeitet mark og mais', 'Her fikk jeg det jeg var ute etter kun 20 min. etter vi annkom drengrud ved drengsrud gård. En av de kuleste fiskene i Norge...', 1);
INSERT INTO fangst VALUES (299, 25, 10, 47, '2006-08-06', 350, 0, 'Storm jig', 'Sto på Evensens flytebrygga og kasta rett ut mellom grunnene. Fikk flere abbor, men denne var klart størst.', 1);
INSERT INTO fangst VALUES (300, 25, 145, 61, '2006-08-06', 60, 0, 'Mark og mais', 'Vippa ut en krok med mark og mais. Vanskelig med mye vekster i vannet, men denne krabaten satt etterhvert.', 1);
INSERT INTO fangst VALUES (301, 25, 143, 62, '2006-08-06', 20, 0, 'Liten krok med mark', 'Mye smått bet på, men solabboren så jeg aldri.', 1);
INSERT INTO fangst VALUES (302, 25, 146, 63, '2006-08-18', 280, 330, 'Bunnmeitet mark', '200 meter før kraftlinja nord for koppang. Fikk 2 til mellom 100 og 250 gram samt en på under 100', 1);
INSERT INTO fangst VALUES (303, 7, 11, 64, '2005-07-16', 1100, 0, 'Stang', 'Tatt på mark', 1);
INSERT INTO fangst VALUES (304, 7, 11, 64, '2005-07-16', 1200, 0, 'Stang', 'Tatt på stang', 1);
INSERT INTO fangst VALUES (305, 7, 11, 64, '2005-07-16', 900, 0, 'Stang', 'Tatt med mark', 1);
INSERT INTO fangst VALUES (306, 7, 11, 64, '2005-07-16', 300, 0, 'Stang', 'Tatt med mark', 1);
INSERT INTO fangst VALUES (307, 7, 145, 61, '2006-08-06', 50, 0, 'Stang', 'Mais', 1);
INSERT INTO fangst VALUES (308, 2, 146, 63, '2006-08-18', 30, 0, 'Fluestang med nymfe', 'Ikke så stor akkurat men det var lenge siden jeg hadde fått prøvd fluestanga og veldig morsomt å få på gammelstanga...', 1);
INSERT INTO fangst VALUES (311, 2, 11, 65, '2006-08-27', 500, 0, 'Milodupp og mark', '5 ørret ville opp denne dag, ny pers!!Milo duppen er super!!!', 1);
INSERT INTO fangst VALUES (313, 2, 134, 15, '2006-09-17', 350, 0, 'makrelldupp med makrellfilet', 'Da vi hørte noen store plask i sandflyndrevika måtte jeg bare hive utti en dupp for å se om det var stor sjøørret. Det viste seg å være en stim med både horngjel og makrell.', 1);
INSERT INTO fangst VALUES (312, 12, 10, 65, '2006-08-27', 80, 0, 'Mark og dupp', '', 1);
INSERT INTO fangst VALUES (314, 2, 22, 15, '2006-09-17', 350, 0, 'makrelldupp med makrellfilet', 'Første makrell på makrell!!', 1);
INSERT INTO fangst VALUES (315, 2, 17, 15, '2006-09-17', 190, 0, 'bunnmeite med perler og makrell', 'Knurr i sandflyndrevika. Mulig dette har med tiden på året men det ble dratt opp en knurr samme dag på 290 gr. av Janne. Hmmm har knurren overtatt? Ellers så vi en sel som svømte rundt i vika, noe vi tror hadde utfall på fiske etterpå da det ble ingenting på de neste 3 timene vi var der.', 1);
INSERT INTO fangst VALUES (316, 7, 17, 15, '2006-09-17', 320, 0, 'Stang', 'Tatt på bunnmeite på Fredvikodden', 1);
INSERT INTO fangst VALUES (317, 39, 14, 15, '2006-09-17', 250, 0, 'Stang', 'Tatt på dupp med makrellfillet, ca. en meter fra land, på Fredvikodden', 1);
INSERT INTO fangst VALUES (318, 39, 22, 31, '2006-09-10', 500, 0, 'stang', 'Tatt fra båt', 1);
INSERT INTO fangst VALUES (319, 2, 147, 67, '2006-09-30', 150, 400, 'Bunnmeite med reke', 'Under målrettet fiske er det ikke noe som er så artig som å dra opp nettopp det.Fikk denne ålen på widegap krok huket med reke motsatt vei påglidende takkel. Så at det var bevegelse i snøre med klarte heldigvis å vente ett par minutter før jeg gjorde tilslag. Prøvde senere og gjøre tilslag med en gang jeg så bevegelse men det resulterte i null fisk.Ålen var ingen kjempe men artig læll. Fy fillern for no gris da!!! ', 1);
INSERT INTO fangst VALUES (320, 8, 22, 15, '2006-09-17', 340, 0, 'Sluk', 'Bra fiske på Tors 30årsdag', 1);
INSERT INTO fangst VALUES (321, 2, 140, 68, '2006-10-08', 80, 0, 'bunnmeite med perler og makrell', '', 1);
INSERT INTO fangst VALUES (322, 25, 140, 69, '2006-10-10', 80, 0, 'Reke eller mark', 'Hadde en krok med reke og en med mark. Fikk Sypike på begge på samme kast. De var omtrent like store, så jeg klarer ikke avgjøre hvem som bet på hva', 1);
INSERT INTO fangst VALUES (323, 25, 147, 69, '2006-10-10', 880, 750, 'Rekeagn', 'En enkel reke på en sirkelkrok. Ålen begynte å dra og dro stødig snøre av snella. Omtrent som å sette seg fast i en snekke på vei til feltet. Ålen var sterk og bortsett fra makrell, den sterkeste fisken på den størrelsen jeg har vært borti.', 1);
INSERT INTO fangst VALUES (324, 2, 140, 69, '2006-10-10', 110, 230, 'bunnmeite med perler og reke', '', 1);
INSERT INTO fangst VALUES (325, 2, 24, 8, '2006-10-17', 590, 0, 'bunnmeite med perler og reke', '', 1);
INSERT INTO fangst VALUES (326, 2, 8, 8, '2006-10-15', 2560, 0, 'bunnmeite med perler og reke', '', 1);
INSERT INTO fangst VALUES (327, 2, 16, 8, '2006-10-16', 590, 0, 'bunnmeite med perler og reke', '', 1);
INSERT INTO fangst VALUES (328, 2, 25, 8, '2006-10-16', 1960, 0, 'bunnmeite med perler og reke', '', 1);
INSERT INTO fangst VALUES (329, 38, 8, 8, '2006-10-15', 5860, 0, 'bunnmeite med perler og sild', '', 1);
INSERT INTO fangst VALUES (330, 7, 24, 8, '2006-10-16', 290, 0, 'bunnmeite med perler og sild', '', 1);
INSERT INTO fangst VALUES (331, 7, 8, 8, '2006-10-15', 2000, 0, 'bunnmeite med perler og sild', '', 1);
INSERT INTO fangst VALUES (332, 2, 8, 68, '2006-01-06', 2840, 0, 'bunnmeite med perler og reke', '', 0);
INSERT INTO fangst VALUES (333, 25, 10, 47, '2007-04-01', 140, 0, 'Pimpel', 'Dro en abbor på 200 gram dagen før. Til sammen 4 abbor på meget begrenset fiske denne helga.', 1);
INSERT INTO fangst VALUES (334, 25, 142, 70, '2007-05-22', 41, 0, 'Mark og dupp', 'Traska cirka 1 kilometer oppover Nitelva fra Hellerudsletta for å lande denne krabaten. Flust med Laue, men ingenting annet på denne plassen.', 1);
INSERT INTO fangst VALUES (335, 2, 135, 36, '2007-05-25', 2990, 0, 'Bunnmeitet laue', 'knarrende morsomt...Fikk endelig den fiskebanken i hjertet igjen da jeg måtte ha hjelp av Morten til å håve dette beistet av en fisk.', 1);
INSERT INTO fangst VALUES (336, 38, 131, 36, '2007-05-25', 1230, 0, 'bunnmeitet mark', '', 1);
INSERT INTO fangst VALUES (337, 38, 133, 36, '2007-05-25', 220, 0, 'bunnmeitet mark', '', 1);
INSERT INTO fangst VALUES (338, 2, 142, 70, '2007-05-22', 38, 0, 'Dupp og mark', '', 1);
INSERT INTO fangst VALUES (339, 2, 10, 36, '2007-05-25', 440, 0, '', '', 1);
INSERT INTO fangst VALUES (340, 25, 10, 47, '2007-06-10', 640, 390, 'Mark og dupp', 'Plutselig renner det inn med abborfangster. Noen turister hadde dratt mellom 10 og 20 da vi kom, vi så pene eksemplarer rundt flytebrygga, og denne bet på 6 meter fra brygga.\r\nNB! merk at denne kom ca 5-6 dager ut i første skikkelige heteperiode i år. Relativt kaldt fram til denne.', 1);
INSERT INTO fangst VALUES (341, 2, 10, 47, '2007-06-10', 670, 395, 'Frilinemeitet mark', 'Dette var en av to store abborer denne dag..det tok ikke lang tid før den satt. Værre var det da jeg alene i båten skulle få den opp. Jeg prøvde det etterhvert så kjente leppegrepe men det gikk ikke å få løftet den. Abboren tok ett utras til av snella før jeg fikk tak rundt nakken og opp i båten. En nydelig fisk som også smakte fortreffelig!!', 1);
INSERT INTO fangst VALUES (342, 25, 11, 47, '2007-06-11', 220, 0, 'Wobler', 'En kveldsdoregetur ga denne ørreten. Sveipa rundt i ca en time.', 1);
INSERT INTO fangst VALUES (343, 7, 128, 44, '2007-06-08', 1780, 0, 'Stang', 'Agnet med loff.', 1);
INSERT INTO fangst VALUES (344, 25, 21, 9, '2007-06-24', 1040, 0, 'Opphengt flue', 'Perset faktisk Lyr i Oslofjorden. Bet på opphengerflue, mens en halvkilostorsk tok sluken.', 1);
INSERT INTO fangst VALUES (345, 25, 134, 9, '2007-06-24', 220, 0, 'Makrellagn under dupp', 'Mange små, men likevel den eneste som bet i dag.', 1);
INSERT INTO fangst VALUES (346, 25, 148, 46, '2007-07-08', 360, 330, 'Bunnmeitet reke', 'Var ute etter berggylte denne noe ruskige sommerkvelden. Gylte ble det og jeg antok at det var blåstål da jeg landet denne norges vakreste fisk. Og gleden stod i taket og jeg våget meg på lommelerkesalutt til tross for at vi offentlig stod på dette pietistiske sørlandet.', 1);
INSERT INTO fangst VALUES (347, 25, 8, 46, '2007-07-09', 2300, 0, 'Bunnmeitet reke', 'Dro ut mot storhavet for å finne Klitten rett utenfor Merdø. Vi fant ca en grunne og der satt denne, etter å ha løsnet fra et leit bunnapp.', 1);
INSERT INTO fangst VALUES (348, 25, 24, 46, '2007-07-08', 260, 0, 'Bunnmeitet reke', 'Som seg hør og bør, ble min cofisker Jarle storligen forbauset og begledet da jeg halte i land denne flyndra og beviste at også flyndre kan tas på stang.', 1);
INSERT INTO fangst VALUES (349, 25, 140, 46, '2007-07-08', 80, 0, 'Bunnmeitet reke', 'Vel denne ble også tatt på brygga på Rævesand.', 1);
INSERT INTO fangst VALUES (350, 25, 127, 71, '2007-07-15', 160, 0, 'Bunnmeitet meitemark', 'På nordsiden av neset på Haugnes er det en undervannsskrent hvor denne morten brukte å like seg', 1);
INSERT INTO fangst VALUES (351, 2, 127, 71, '2007-07-15', 180, 0, 'kulesøkke og krok med mark', 'I sterk kuling med vind i fra sør korket jeg denne morten på haugnesodden nord for grunna.. En av flere mort i samme klasse. Tror dette er en av hotspottene for fiske året rundt...', 1);
INSERT INTO fangst VALUES (352, 2, 149, 72, '2007-07-25', 1110, 633, 'Bunnmeitet makrell på morfars gamle stang', 'Sinnsykt... Dette er den fineste fisken jeg har noen gang tatt.Hai i Norge er IKKE hverdags og denne gjorde kvelden perfekt.Det er så morro med resultat etter ordentlig research/gutsing....', 1);
INSERT INTO fangst VALUES (353, 25, 150, 72, '2007-07-28', 120, 0, 'Aktivt bunnmeite med reke', 'Storsatsning på rødhai feilet, men trøstepremien var en ny art.', 1);
INSERT INTO fangst VALUES (354, 25, 124, 72, '2007-08-16', 540, 380, 'Bunnmeitet makrellfilet', '', 1);
INSERT INTO fangst VALUES (355, 2, 136, 73, '2007-09-22', 860, 0, 'Ostepølse og feederkurv', 'Ny fiskemetode med feederkurv og fòr og krok agnet med kalkunostepølse. Meget artig å få full uttelling da jeg manglet stam på lista.Ok størrelse også.', 1);
INSERT INTO fangst VALUES (356, 7, 136, 73, '2007-09-22', 580, 0, 'Ostepølse og feederkurv', '', 1);
INSERT INTO fangst VALUES (357, 28, 10, 73, '2007-09-22', 160, 0, 'mark + dupp', 'Ytters på odden\r\nEt blyfeste på lodden\r\npakka vekk i-poden\r\nslå nå den!', 1);
INSERT INTO fangst VALUES (358, 25, 10, 47, '2008-03-17', 260, 0, 'Mormyska med mark', 'Småfisken bet fint denne påska. Akkurat denne abboren hadde gomlet i seg en del overskuddsmark som jeg hadde slengt i hullet. Ellers fikk Oda røye, ørret og abbor på denne turen, alle rundt 100 gram. Fiskene ble fanget 30 meter øst for brygga.', 1);
INSERT INTO fangst VALUES (359, 25, 131, 38, '2008-04-20', 1160, 0, 'Mark', 'Tok denne på godplassen noe sør for jernbanebrua til Lillestrøm. Eneste fisk denne dagen, men likevel, årets første fisk.', 1);
INSERT INTO fangst VALUES (360, 2, 134, 74, '2008-05-06', 300, 0, 'Makrelldupp med reke', '', 1);
INSERT INTO fangst VALUES (361, 2, 24, 74, '2008-05-06', 160, 0, 'Bunnmeite med reke', 'Tatt til høyre i vika med sandbunn', 1);
INSERT INTO fangst VALUES (362, 2, 16, 54, '2008-05-01', 2510, 0, 'Bunnmeite med reke og mutter', 'Nydelig hyse på en spontantur.Ikke verdagskost for oss søringa.Sjøørreten vaken som besett i vannflata.', 1);
INSERT INTO fangst VALUES (363, 38, 24, 75, '2008-05-02', 310, 0, 'Bunnmeite med reke', 'Min første sandflyndre. Fikk skjelvinga!!', 1);
INSERT INTO fangst VALUES (364, 30, 25, 76, '2008-05-31', 1500, 0, 'Stang', 'Var 2 timer ute i båt og fikk stort sett bare småtorsk og småsei. Gikk etterpå ut på moloen og fikk en lekker sei.', 1);
INSERT INTO fangst VALUES (365, 25, 137, 47, '2008-06-14', 8, 0, 'Microkrok med micromark', 'Kasta ut en en 1,5 liters felle med lettkokte havregryn og fikk 1 ørekyte.\r\n\r\nDet ble til at vi fant fram microkrokene og fisket manuelt. Perset med ørekyte på 8 gram. Må si at norgesrekorden på 40 er overraskende stort i forhold til de kytene vi så.\r\n\r\nAbborfisket ble suksess i den forstand at det faktisk ble fisk på ørekyta. Størrelsen var imidlertid skuffende og den største abboren på ca 300 gram bet faktisk mens vi fisket ørekyte. Skal si jeg skvatt da denne sluggeren på grundt vann dukket opp og slukte microkroken min. Microsnøret klarte dessverre ikke påkjenningen og etter kort tid kunne abboren svømme videre med anbefalt dagsdose kirurgisk stål innabords.\r\n\r\nØrekyteagning skal prøves igjen, men da skal vi ha en større og bedre felle til snacksen.', 1);
INSERT INTO fangst VALUES (366, 2, 148, 46, '2008-06-24', 335, 290, 'paternoster med reke', 'Endelig kunne jeg smykke meg med denne nydelige arten. Supert sted med masse fisk.', 1);
INSERT INTO fangst VALUES (367, 2, 151, 46, '2008-06-24', 785, 360, 'paternoster med reke', 'Morsomt og endelig få denne arten.Plassen ga 4 arter på 4 kast.Genial start på an hard morgen etter konsertene.', 1);
INSERT INTO fangst VALUES (368, 2, 140, 46, '2008-06-24', 110, 195, 'paternoster med reke', 'nå også med bilde!', 1);
INSERT INTO fangst VALUES (369, 2, 148, 46, '2008-06-24', 0, 260, 'paternoster med reke', 'Rødnebb: Er jo ikke en egen art men morsomt å se kjønnskiftet...', 1);
INSERT INTO fangst VALUES (370, 2, 137, 47, '2008-06-14', 6, 0, 'Microkrok og markdel', 'Gigafiske på mylla!!!', 1);
INSERT INTO fangst VALUES (371, 25, 12, 47, '2008-07-04', 200, 0, 'Wobler', 'Dorget etter snacks og fikk denne siken. Første sik på dorging.', 1);
INSERT INTO fangst VALUES (372, 30, 22, 8, '2008-07-09', 820, 0, 'sluk', 'Vi så makrellen komme forbi Einar-brygga, vi kastet mitt i og tok til sammen 5 makrell.', 1);
INSERT INTO fangst VALUES (373, 2, 154, 78, '2008-07-11', 315, 380, 'Bunnmeite med reke ', 'Utrolig morsom fisk som ventet helt til sommerferiens siste kast med å bite på kroken. Fjesingen kjentes ut som en makrell når den bet på og så ut som en hvitting i overflata. ', 1);
INSERT INTO fangst VALUES (374, 2, 155, 78, '2008-07-11', 75, 165, 'Bunnmeite med reke ', 'Første kast på ny plass er alltid morsomt. Veldig morsomt ble det da det jeg trodde var bergnebbbitt viste seg og være ny art da den dukket opp.', 1);
INSERT INTO fangst VALUES (375, 2, 153, 78, '2008-07-11', 185, 255, 'Bunnmeite med reke ', 'Denne flyndra ble fort glemt da jeg hadde fått grønngylt først og fjesing etter da jeg trodde det dreide seg om ei skrubbe med flekker. Først når jeg kom hjem til Oslo kunne jeg studere bildene nærmere (etter noe grubbling på at det kunne være....) Ble sinnsykt glad da det viste seg å være også. Særlig siden jeg og Simen hadde tenkt på denne arten lenge.. Skal nok ikke gå så veldig lang tid før jeg perser men..Til høsten og utover blir det nok lite fisking..!!.. ', 1);
INSERT INTO fangst VALUES (376, 25, 138, 8, '2008-07-12', 760, 0, 'Bunnmeitet reke', 'På odden ved rødhytta, bare 300 meter unna furuly, ble denne rakkeren tatt. Den var sterk og kjørte seg fast et par ganger.', 1);
INSERT INTO fangst VALUES (377, 25, 139, 29, '2008-07-15', 10080, 1020, 'Bunnmeitet makrellfilet', 'Brosmen bet etter at jeg allerede hadde sikret en annen på 3 kilo. Dro også opp et par på 6-7 kilo. Hadde flere som glapp etter å ha sveivet dem inn ca 50 meter. Og posisjonen? OK. N66.48.127, E013.25.729. Skitt fiske.', 1);
INSERT INTO fangst VALUES (378, 10, 22, 8, '2008-07-14', 760, 0, 'Stang', 'Ble tatt på Einar Erlendkaia på Grønøy en sen sommerkveld med regn i lufta', 1);
INSERT INTO fangst VALUES (379, 9, 22, 8, '2008-07-09', 680, 0, 'Stingsild', 'Fra brygga på Grønøy', 1);
INSERT INTO fangst VALUES (380, 25, 147, 79, '2008-07-25', 580, 0, 'Bunnmeitet reke', 'Bunnmeitet reke og kun reke ga kveldens første pene utras', 1);
INSERT INTO fangst VALUES (381, 25, 144, 79, '2008-07-26', 650, 320, 'Bunnmeitet reke og mais med fórkurv', 'Kroket noen sekunder etter første tegn. Thomas håvet strålende og fisketuren ble en suksess. Fisket i hjørnet på grusbanen mot gressbanen der greåkerelva starter.', 1);
INSERT INTO fangst VALUES (382, 2, 144, 79, '2000-07-25', 120, 0, 'feederkurv og mais/reke', 'Skulle vært større men målrettet fiske ga resultat!', 0);
INSERT INTO fangst VALUES (383, 2, 144, 79, '2000-07-25', 120, 0, 'feederkurv og reke/mais', 'Skulle vært større men målrettet fiske ga resultat!', 0);
INSERT INTO fangst VALUES (384, 25, 135, 36, '2008-07-28', 1560, 0, 'Bunnmeitet laue', 'Andre utras i løpet av to timer ble kroket. Hadde også et napp på en sølvkroken spesial, men den slapp 10 meter fra land. Ellers virket det svært dødt bortsett fra en kaill som bedrev matauk med levende laue.', 1);
INSERT INTO fangst VALUES (385, 10, 24, 15, '2008-07-30', 240, 0, 'Krok med reke', '', 1);
INSERT INTO fangst VALUES (386, 10, 142, 36, '2008-07-28', 12, 0, 'krok med mark', '', 1);
INSERT INTO fangst VALUES (387, 10, 8, 15, '2008-07-30', 260, 0, 'Krok med reke', '', 1);
INSERT INTO fangst VALUES (388, 41, 8, 8, '2008-07-14', 3000, 0, 'Hekle', '', 1);
INSERT INTO fangst VALUES (389, 2, 144, 79, '2008-07-26', 120, 0, 'feederkurv og reke/mais', 'målrettet fiske gir resultat om kanskje litt liten...', 1);
INSERT INTO fangst VALUES (390, 2, 144, 79, '2008-08-09', 460, 300, 'widegap m/reke,mais,isopor + feederkurv ', 'RÅ kamp med luftige svev ga denne sørven som en av de første fiskene denne kveld, Hjemmelaget fòr funket bra (havregryn,mel,rekesaft og maissaft). ', 1);
INSERT INTO fangst VALUES (391, 30, 10, 36, '2008-08-15', 16, 0, 'markstang', 'det var kjedelig ', 1);
INSERT INTO fangst VALUES (392, 30, 133, 36, '2008-08-15', 140, 0, 'markstang', '', 1);
INSERT INTO fangst VALUES (393, 11, 141, 36, '2008-08-15', 28, 0, 'Markstang', 'Store fisker som vaka og hoppa, men eg endt opp med en hork på 28 gram..', 1);
INSERT INTO fangst VALUES (394, 30, 11, 80, '2008-08-21', 271, 310, 'Stang/spinner', 'En kveldstur til ranelva nedenfor Amlia i dunderlandsdalen. Mye fisk som hoppa. Etter litt strategisk kasting kom storfisken etter bare 10 minutter. En litt mindre ørret beit på litt etter. Ingen flere fisk iløpet av den neste timen...', 1);
INSERT INTO fangst VALUES (395, 11, 11, 80, '2008-08-12', 164, 260, 'stang/spinner', 'Ranelva, dunderlandsdalen, Almlia. En kort fisketur på kvelden ga gode resultater. Totalt 6 ørret på 1 time fordelt på 3 personer.', 1);
INSERT INTO fangst VALUES (396, 42, 147, 81, '2008-08-27', 280, 450, 'Bunnmeitet reke', 'Kveldens siste forsøk, hadde egentlig gitt opp og var mest opptatt av Simens nye lekre mobiltelefon...', 1);
INSERT INTO fangst VALUES (399, 41, 10, 47, '2009-01-11', 100, 210, 'Pimpel', 'JEG KJENTE VELDIG MYE OGSÅ KOM FISKEN VELDIG FORT. JEG VISTE DEN FRAM TIL MAMMA.', 1);
INSERT INTO fangst VALUES (398, 25, 12, 47, '2009-01-10', 140, 0, 'pimpel', 'første fangst ved den nye øya i vika\r\n', 1);
INSERT INTO fangst VALUES (400, 25, 8, 53, '2009-01-17', 1840, 0, 'Makrellagn på bunnen', 'Fin dag på isen. minus 1, lite vind og fisk til alle. Det ble tatt Hvitting, Torsk, Sandflyndre og Sei.', 1);
INSERT INTO fangst VALUES (401, 7, 24, 53, '2009-01-17', 240, 0, 'Makrellagn på bunnen', 'Ingen kommentar', 1);
INSERT INTO fangst VALUES (402, 2, 25, 53, '2009-01-17', 3790, 880, 'paternoster med feederkurv,reke', 'Største fisk tatt i Oslofjorden.. Meget spennende kamp. Ble usikker om vi måtte borre et til hull for å få den opp. Takk til Simen for klepping og Dario for filming. Filmen kan sees på facebook.', 1);
INSERT INTO fangst VALUES (403, 25, 8, 9, '2009-04-05', 4580, 0, 'Makrellfilet', 'Torsken bet på omtrent full flo 10 minutter etter jeg fikk kasta ut. Var muligens uheldig med floa i dag for dette ble den eneste fisken. Dette er foreløpig den største fisken jeg har tatt fra land. Den ble kjørt hardt for å unngå at den kjørte seg fast. Med dette stempler jeg surfstanga: GODKJENT!', 1);
INSERT INTO fangst VALUES (404, 41, 10, 47, '2009-04-11', 100, 0, 'Pimpel', '', 1);
INSERT INTO fangst VALUES (405, 25, 17, 46, '2009-07-05', 420, 0, 'Rekeagn', 'Ble tatt i nærheten av grunna Klitten utenenfor Hove på ca 100 meters dyp. Jeg er glad for at dette kompletterer bildesamlingen av mine perser.', 1);
INSERT INTO fangst VALUES (406, 30, 8, 8, '2009-07-13', 7600, 930, 'havfiskestang', 'Vi tok den mellom Grønnøy og Åmøy.\r\nStanga bøyde seg kraftig og den var skummel sterk.\r\nDen holdt på å ta med seg stanga før jeg fikk kontrollen over monsteret', 1);
INSERT INTO fangst VALUES (407, 10, 140, 82, '2009-07-13', 100, 0, 'Stang', '', 1);
INSERT INTO fangst VALUES (408, 10, 25, 82, '2009-07-13', 400, 0, 'Stang', '', 1);
INSERT INTO fangst VALUES (409, 25, 19, 83, '2009-07-14', 120, 0, 'makrellagn på bunnen', 'Den minste langen jeg har sett, likevel var den en 25-30 cm', 1);
INSERT INTO fangst VALUES (410, 25, 15, 83, '2009-07-14', 350, 0, 'makrellagn på bunnen', 'Den eneste hvittingen vi fikk på turen', 1);
INSERT INTO fangst VALUES (411, 25, 156, 83, '2009-07-14', 40, 250, 'makrellagn på bunnen', 'Noe tungt på, jeg var sikker på tang. I en stor klase av bunnslam og noe som kunne minne om en glassmanet fant jeg denne slimålen. Etter intens slimrensing og graving kunne jeg konstatere at kroken satt i den ene enden av slimålen, den enden jeg antar var hodeenden og at kroken gikk inn i noe som lignet spiseutstyret til utenomjordiske monstre. Leif Atle er vitne til korrekt kroking. Noe senere på kvelden hadde jeg faktisk en til slimål på samme størrelse, den slapp imidlertid på vei fra vannet og opp til kaia.', 1);
INSERT INTO fangst VALUES (412, 29, 16, 83, '2009-07-14', 250, 0, 'Bunnmeitet makrell', 'Etter å ha kastet ut igjen en del småsei og torsk tatt på den nye surfstanga, innså jeg at skal det bli noen arter på meg her på draugen må jeg begynne å registrere all småfisken min. Så her kommer den første registrerte saltvannsfisken min. Hyse på 250 gram da gitt!', 1);
INSERT INTO fangst VALUES (415, 25, 19, 84, '2009-07-19', 2300, 0, 'Makrellfilet', 'Den förste fisken som bet på denne turen. Den ble tatt på fiskefingrene og ca 40 meters dyp.', 1);
INSERT INTO fangst VALUES (414, 25, 24, 82, '2009-07-13', 300, 0, 'makrellagn paa bunnen', 'grei brakkvannsflyndre. fikk ogsaa en flyndre paa utsiden av moloen.', 1);
INSERT INTO fangst VALUES (416, 25, 157, 84, '2009-07-19', 1500, 0, 'Sei', 'Agnet opp med en 3-4-hundre-grams sei, skar ut halve ryggbeinet og senket den på 50-60 meter. Denne breiflabben hadde slukt hele seien, men gulpet den opp da vi lirket ut kroken.', 1);
INSERT INTO fangst VALUES (417, 25, 128, 44, '2009-07-26', 2080, 490, 'Flytebrød', 'Hadde kun hamburgerbrød. Slet vanvittig fo å få det til å sitte på kroken i kastet og lenge nok til å komme over fisken. Kontrollmåling av vekt viste at fisken veide det samme som en 750-grams svenskpilk, en 400-gams svenskpilk, en 400-grams annen pilk, et 300-grams blylodd, et 150-grams surflodd og et 20-grams pærebly. Forøvrig fikk jeg også et par vederbuk på 1,5 kilo.', 1);
INSERT INTO fangst VALUES (418, 10, 8, 8, '2009-08-06', 740, 0, 'Sluk', 'Tatt fra einar erlend-brygga. Kjedelig med torsk, men desto morsommere når rafael dunka den i hodet med verdens største jernstang', 1);
INSERT INTO fangst VALUES (419, 10, 22, 8, '2009-08-06', 720, 0, 'Sluk', 'Tatt fra einar erlend-brygga, skulle egentlig bare knyte opp knuten på snøret, og så var det jaggu en makrell der! Fikk den nesten ikke opp, men rafael hjalp meg når den satt seg fast utafor bryggekanten. Vel oppe på brygga sleit den snøret!', 1);
INSERT INTO fangst VALUES (420, 10, 8, 8, '2009-08-09', 1100, 0, 'Jukse', '', 1);
INSERT INTO fangst VALUES (421, 2, 128, 44, '2009-08-25', 1600, 0, 'popup mais og seig loff', 'en 40 minutters tur med sovende barn i barnevogna like ved ga denne morgenfangsten, tatt 0930 på en soldag.\r\nNoen minutter etter johanne våknet startet regnet.', 1);
INSERT INTO fangst VALUES (422, 2, 17, 15, '2009-09-15', 220, 0, 'reke med gule popup kuler', 'fast fisk etter 5 min mitt i solsteken tidlig på floa mitt på dagen. ellers to napp men ikke no mer. Det går an å meite med 11mnd baby (johanne)!', 0);
INSERT INTO fangst VALUES (423, 2, 15, 53, '2010-01-16', 250, 0, 'liten makrellbit med gummiblekksprut ', '', 1);
INSERT INTO fangst VALUES (424, 2, 132, 38, '2010-04-19', 2660, 750, 'Sluk', 'Ny sluk ga større gjedde..\r\nAldri hatt no tu på sluken men den ga uttelling', 1);
INSERT INTO fangst VALUES (425, 7, 156, 29, '2010-05-21', 19, 0, 'takkel', 'Æsj!!!!', 1);
INSERT INTO fangst VALUES (426, 25, 15, 29, '2010-05-22', 800, 0, 'Makrell', 'Makrelltakkel på ca 70 meter. Nordsida av Oksholmen leverte nok en gang. Vi kom etterhvert ned til ca 300 meter, men steindødt der.', 1);
INSERT INTO fangst VALUES (427, 7, 138, 29, '2010-05-22', 1470, 0, 'Takkel', 'Etter et trøstesløst døgn, uten noe av betydning, ble det endelig tungt å dra. I skrekkslagen, vill glede ble steinbiten dratt ombord. Kjeften sto vidåpen og kroppen krøllet seg rundt seg selv, men i bøtta havnet den. Den gikk på krok med blekksprut over og en halv makrellfillet under, på en grunne på ca. 40 meter. Etter at Simen hadde avkroket den og Thomas veid den ble den med hjem for å bli til middag.', 1);
INSERT INTO fangst VALUES (428, 25, 19, 29, '2010-05-23', 2180, 0, 'makrell', 'Fikk langen på  bunnen mellom kjerkholmen og laksneset som forøvrig også huset en grunne med mye stor torsk og små sei', 1);
INSERT INTO fangst VALUES (431, 7, 138, 29, '2010-05-23', 2180, 0, 'Pilk', 'For en sinnsyk fangst! Da jeg dro inn tenkte jeg først et par sei, siden det var ganske livlig draing. Deretter ble det seigt og rolig der nede, så jeg tenkte torsk. Da fisken kom opp langs ripa ble det klart at det lå an til nok en rekord-steinbit! Mens det i villels ble lett etter klepp slapp fisken kroken!!! I tumultene som oppsto klarte Simen å hive seg over ripa med kleppen. Han hogg til og kleppet den i halen! Opp i båten kom den! I kaoset vugget båten så mye at Thomas, som satt frempå båten, gled ned! Med bena i vannet fikk han tak i tak-håndtaket og kom seg opp igjen. Først da det hele roet seg og skjelven hadde gitt seg tenkte vi over det merkelige i at Steinbit gikk på pilk.. Også denne steinbiten ble tatt på ca. 40 m dyp.', 1);
INSERT INTO fangst VALUES (432, 7, 8, 8, '2010-05-23', 6460, 0, 'Pilk (og Sei)', 'Nok en fantastisk fiskehistorie! Da jeg kjente at noe gikk på kroken var det ganske sikkert at det var en sei, siden vi fisket i en Seistim. Mistanken ble bekreftet når fisken kom opp langs siden av båten. -En liten Sei på ca 200 g. Mens jeg somlet med å dra den opp så vi plutselig at det var en kjempetorsk på jakt rett bak! Jeg dro seien gjennom vannet og Torsken hugg til! Utrolig nok kom seien seg løs, mens torsken fikk et godt tak i pilken og satt som et skudd!', 1);
INSERT INTO fangst VALUES (433, 2, 8, 29, '2010-05-23', 12360, 1080, 'hel agnfisk', 'stor torsk ja, første forsøk på fiske med hel agnfisk. jighode og treblekrok. Satt fast kun i jighode.', 1);
INSERT INTO fangst VALUES (434, 25, 139, 29, '2010-05-24', 10420, 1040, 'Hel makrellfilet på sirkelkrok', 'Brosmen bet på ca 180 meters dyp og var oppe på et kvarter. Kunne trengt en noe større stamp her på Grønøy til slike eksemplarer', 1);
INSERT INTO fangst VALUES (435, 2, 139, 29, '2010-05-24', 7800, 900, 'brosmetakkel,selvknytt', 'Ser ut til at vi fant ut hvor brosma stod på denne turen. Tok helt på bunn.', 1);
INSERT INTO fangst VALUES (436, 2, 139, 29, '2010-05-24', 6600, 8300, 'brosmetakkel,selvknytt', 'Første brosme. Glad som en lyr...', 1);
INSERT INTO fangst VALUES (437, 25, 15, 29, '2010-05-24', 1800, 600, 'makrell', 'Turens siste fisketur vest på Oksholmen ga hvitting og brosme. fra 120 meter til 160 levde hvittingen og brosmen tok over derfra og nedover til 200.', 1);
INSERT INTO fangst VALUES (438, 2, 128, 44, '2010-05-31', 1940, 0, 'gourmetloff', 'dette var en av tre buker på hhv 1.60 og 1.64 hvor denne bet sist like før jeg skulle dra.. prøvde med reker og loff for å unngå all morten-hjalp lite..Det ser ut til at morten roer seg ved mørkets frambud (ca klokka 22:00)', 1);
INSERT INTO fangst VALUES (439, 25, 153, 8, '2010-07-23', 440, 0, 'Rekeagn med dingeldangel', 'Kastet ut rett utenfor flytebrygga mens jeg ryddet etter fisketur. Innsveivingen tok jeg meg god tid på og da satt den.', 0);
INSERT INTO fangst VALUES (440, 41, 20, 8, '2010-07-23', 300, 0, 'Hekle', 'Vi var ute med båten ved hyshølet. De i båten var Magnus, Rafael, Marius, Lene og meg.', 1);
INSERT INTO fangst VALUES (441, 27, 8, 8, '2010-07-25', 1820, 0, 'Stingsild', 'Ute i båten med Carl-Arne, Simen, Rafael og Magnus da denne kjempen bet på. Den var tung å sveie opp, men pappa har lovet å kjøpe ny fiskestang. Ett lett sjøfiske-sett til 6-7 hundre kroner.', 1);
INSERT INTO fangst VALUES (442, 30, 139, 29, '2010-07-25', 9100, 940, 'Hel makrellfilet', 'Denne bet på sammen med en mindre brosme på ca 1,5 kg. Den var tung å sveive opp og det tok lang tid. Da den kom opp kastet den opp en 300-grams hvitting og diverse væsker. Alle var med og tok bilder da vi kom i land.', 1);

-- --------------------------------------------------------

-- 
-- Table structure for table 'fisker'
-- 

CREATE TABLE fisker (
  ID int(11) NOT NULL,
  navn varchar(50) NOT NULL default '',
  etternavn varchar(50) NOT NULL default '',
  brukernavn varchar(10) NOT NULL default '',
  passord varchar(10) NOT NULL default 'passord',
  rettigheterID int(11) NOT NULL default '1',
  email varchar(200) NOT NULL default '',
  innlogget char(1) character set latin1 collate latin1_bin NOT NULL default '0',
  innlogginger int(11) NOT NULL default '0',
  sistinnlogget datetime NOT NULL default '0000-00-00 00:00:00',
  minstem�l int(11) NOT NULL default '0',
  "timestamp" double NOT NULL default '1019604933',
  stilID int(11) NOT NULL default '1',
  Bilde varchar(200) NOT NULL default 'img\\logo.jpg',
  PRIMARY KEY  (ID)
);

-- 
-- Dumping data for table 'fisker'
-- 

INSERT INTO fisker VALUES (2, 'Thomas', 'Sneipen', 'thomas', 'arctander7', 3, 'furuly23@hotmail.com', 0x30, 1435, '2010-07-26 09:04:35', 100, 1139312282, 1, 'http://home.chello.no/~seriksen2/images/tdraug153.jpg');
INSERT INTO fisker VALUES (7, 'Janne', 'Furuly', 'janne', 'janne', 3, 'janne', 0x30, 36, '2010-05-26 10:25:26', 100, 0, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (8, 'Geirs', 'Muskelen', 'geir', 'ding01', 2, 'GeirS', 0x30, 15, '2008-12-30 12:14:56', 100, 0, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (9, 'Lene', 'Mama', 'lene', 'lene', 2, 'lene.evensen', 0x30, 16, '2009-08-12 08:48:19', 100, 0, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (10, 'Ingri', 'Søs', 'ingri', 'ingri', 2, 'ingriher@stud.ntnu.no', 0x30, 35, '2009-08-09 16:10:07', 100, 1138394413, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (11, 'Marius', 'Massefar', 'marius', 'marius', 2, 'eiteraa', 0x30, 15, '2008-08-21 21:57:44', 100, 1122293973, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (12, 'Silje', 'søta', 'silje', 'silje', 2, 'torbergsen23@hotmail.com', 0x30, 6, '2006-03-21 21:23:04', 100, 0, 1, 'img\\logo.jpg');
INSERT INTO fisker VALUES (25, 'Simen', 'BadAss', 'simen', 'simen', 3, 'simen.eriksen@hotmail.com', 0x30, 912, '2010-07-25 10:22:10', 100, 1139313161, 0, 'http://home.chello.no/~seriksen2/images/tdraug183.jpg');
INSERT INTO fisker VALUES (26, 'Håkon', 'Nepa', 'håkon', 'håkon', 1, '', 0x30, 1, '2005-05-30 14:24:30', 100, 0, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (27, 'Maja', 'Fiskerjenta', 'maja', 'maja', 2, 'Maja.Furuly@sensewave.com', 0x30, 17, '2007-03-29 22:29:51', 100, 1139178947, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (28, 'Kim-frode', 'Kimberto', 'kimbert', 'kimbert', 2, 'edorfmik@hotmail.com', 0x30, 101, '2008-07-18 20:11:42', 100, 1139310552, 0, 'http://home.chello.no/~seriksen2/images/tdraug155.jpg');
INSERT INTO fisker VALUES (29, 'Leif Atle', 'leffa', 'leffa', 'leffa', 2, '', 0x30, 29, '2009-08-16 05:05:36', 100, 1122018249, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (30, 'Rafael', 'Stjerna', 'Rafael', 'Rafael', 1, '', 0x30, 5, '2009-07-13 19:37:29', 0, 1019604933, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (36, 'Joakim', 'Bionicle', 'joakim', 'joakim', 1, '', 0x30, 1, '2005-07-25 14:28:35', 0, 1122294636, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (37, 'Lars petter', 'Belseth', 'Lars', 'passord', 2, '', 0x30, 0, '0000-00-00 00:00:00', 100, 1019604933, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (38, 'Morten', '', 'morten', 'passord', 2, '', 0x30, 0, '0000-00-00 00:00:00', 0, 1019604933, 4, 'img\\logo.jpg');
INSERT INTO fisker VALUES (35, 'Glenn', 'Langbråten', 'Glenn', 'passord', 1, 'nnelg@online.no', 0x30, 13, '2006-03-11 00:54:13', 0, 1137863189, 1, 'http://home.chello.no/~seriksen2/images/tdraug217.jpg');
INSERT INTO fisker VALUES (39, 'Mina', '', 'mina', 'mina', 1, '', 0x30, 0, '0000-00-00 00:00:00', 0, 1019604933, 1, 'img\\logo.jpg');
INSERT INTO fisker VALUES (40, 'Bjørn', 'Bjørna', 'Bjørn', 'passord', 1, '', 0x30, 0, '0000-00-00 00:00:00', 0, 1019604933, 1, 'img\\logo.jpg');
INSERT INTO fisker VALUES (41, 'Oda', 'Eriksen', 'Oda', 'passord', 1, '', 0x30, 0, '0000-00-00 00:00:00', 0, 1019604933, 1, 'img\\logo.jpg');
INSERT INTO fisker VALUES (42, 'Kjell', 'Bremmen', 'Kjell', 'passord', 1, 'kjell.breimo@gyldendal.no', 0x30, 4, '2008-09-26 08:50:19', 0, 1019604933, 1, 'img\\logo.jpg');
INSERT INTO fisker VALUES (43, 'Darío ', 'del Rondin', 'Dario', 'passord', 0, 'cronostrigger@hotmail.com', 0x30, 0, '0000-00-00 00:00:00', 0, 1019604933, 0, '');

-- --------------------------------------------------------

-- 
-- Table structure for table 'rettigheter'
-- 

CREATE TABLE rettigheter (
  ID int(11) NOT NULL,
  navn varchar(50) NOT NULL default '',
  kommentar text NOT NULL,
  PRIMARY KEY  (ID)
);

-- 
-- Dumping data for table 'rettigheter'
-- 

INSERT INTO rettigheter VALUES (1, 'Draugling', 'Innlegg i gjest');
INSERT INTO rettigheter VALUES (2, 'Draug', 'Innlegg av fangst, sted, art og gjest\r\nEndring av sted, art, egen fangst og egen fisker');
INSERT INTO rettigheter VALUES (3, 'Stordraug', 'Innlegg/endring av fangst, sted, gjest, fisker og link');
INSERT INTO rettigheter VALUES (4, 'Webmaseter', 'Innlegg/endring av fangst, sted, gjest, fisker, link og rettigheter');

-- --------------------------------------------------------

-- 
-- Table structure for table 'sted'
-- 

CREATE TABLE sted (
  ID int(11) NOT NULL,
  navn varchar(50) NOT NULL default '',
  kommentar text NOT NULL,
  fullnavn varchar(50) default NULL,
  PRIMARY KEY  (ID)
);

-- 
-- Dumping data for table 'sted'
-- 

INSERT INTO sted VALUES (71, 'hurdalsjøen', 'Stor sjø. Snittdybde på 35 meter.', NULL);
INSERT INTO sted VALUES (47, 'mylla', 'Et stort vann i nordmarka 496 meter over havet. Huser Abbor, Ørret, Sik, Røye, Lake og Ørekyte.', 'Myllhøttgrunna');
INSERT INTO sted VALUES (7, 'Langøyene', 'Klippelandskapet på nordsia av Langøyene.', 'Langøybaksia');
INSERT INTO sted VALUES (8, 'Grønøy', 'Grønøysundet: Sundet under storbrua over til Grønøy. Marius påstår at en Kveite sleit hans 0.90-snøre her. \r\nHyshølet: Fiskebanke 100 meter nord for dampskipskaia på Grønøy. Har gitt mye fint. Storstor Lyr, Lange, Torsk, Hyse, Kveite m.m. Hyshølet\r\nGrønøystilla: Området bak Grønøy i lagunen ved brua til den derre andre høye øya med de fjella Grønøystilla.', 'Grønøysundet');
INSERT INTO sted VALUES (9, 'Rambergøya', 'Odde på Rambergøya med godt fiske rambergodden.Fredvikberget: . Rambergdypet: . Rambergodden: . Rambergberget: .', 'rambergodden');
INSERT INTO sted VALUES (10, 'Rolfstangen', 'På Snarøya, sør for gamle Fornebu rolfstangen', 'rolfstangen');
INSERT INTO sted VALUES (11, 'Lysakermoloen', 'Lysakermoloen Lysakermoloen Lysakermoloen', 'Lysakermoloen');
INSERT INTO sted VALUES (13, 'Frydenlunddammen', 'En bortgjemt dam i nordmarka. Full av mikroskopiske Karuss Frydenlunddammen', 'Frydenluunddammen');
INSERT INTO sted VALUES (15, 'Gressholmen', 'Fredvikodden: Odden ved vika som skiller Gressholmen fra Rambergøya. Håkberget: Berget rett til høyre når man går i land fra rutebåten, relativt dypt.', 'Fredvikodden');
INSERT INTO sted VALUES (16, 'Fornebu', 'En steinete vik rett utenfor Statoilstasjonen på Fornebu (som nå er lagt ned): Fornebusteina', 'Fornebusteina');
INSERT INTO sted VALUES (18, 'Dalselv', 'Mellom bilbrua og jernbanebrua i Dalselv Dalselvbrua', 'Dalselvbrua');
INSERT INTO sted VALUES (19, 'Vestre fyllingen', 'Vann i nordmarka Vestre fyllingen', 'Vestre fyllingen');
INSERT INTO sted VALUES (61, 'drengsrudvannene', 'Vann i Asker kjent for dvergmalle. En god del vannliljer på sommeren noe som gjør fisket vannskelig.', NULL);
INSERT INTO sted VALUES (22, 'Store åklungen', 'I en vik på nordsiden av vannet Store Åklungen', 'Store Åklungen');
INSERT INTO sted VALUES (23, 'Belteren', 'I nærheten av gjennomgangen til Mylla belteren', 'belteren');
INSERT INTO sted VALUES (25, 'Vippetangen', 'Noe utrivelig på kveldstid. Mange biler med skumle hensikter. vippetangkaia', 'vippetangkaia');
INSERT INTO sted VALUES (26, 'Slottet', 'Mangler Slottet', 'Slottet');
INSERT INTO sted VALUES (29, 'Meløyfjorden', 'I fjorden utenfor Grønøy har vi ettervært oppdaget spennende fiske etter pelagisk fisk. Ca 200 meter dypt med litt pluss og litt minus. Bunnfiske er lite prøvd her av oss, men vi har muligens funnet en sagnomsust uerplass her. meløyfjorden', 'meløyfjorden');
INSERT INTO sted VALUES (31, 'Hvaler', ' Hvaler', 'Hvaler');
INSERT INTO sted VALUES (32, 'Gåstjønna', ' Gåstjønna', 'Gåstjønna');
INSERT INTO sted VALUES (34, 'Bjørnsjøen', ' Bjørnsjøsmalen', 'Bjørnsjøsmalen');
INSERT INTO sted VALUES (35, 'Glommautløpet', ' glommautløpet', 'glommautløpet');
INSERT INTO sted VALUES (36, 'Dynovika', ' Dynovika', 'Dynovika');
INSERT INTO sted VALUES (37, 'Lysakerelva', 'Viktig skille mellom lakseførende elv under fossen og vanlig elv over. Ålen går hele veien.', 'Lysakerelva øvre');
INSERT INTO sted VALUES (38, 'Nitelva', ' Rælingsbrua. Dynotarmen: .', 'Rælingsbrua');
INSERT INTO sted VALUES (40, 'Åros', ' Åros', 'Åros');
INSERT INTO sted VALUES (41, 'Leira', 'Nederst i Leira er det en fin fiskeplass ikke langt fra Dynovika.', 'leira, nedre');
INSERT INTO sted VALUES (42, 'Hydrobrygga', 'Stor rekkevidde til relativt grunne områder. Torsk og sandflyndre er tatt her. Pent område. Sannsynligvis fryktelig mange turgåer og romantikere på fine sommerkvelder. hydrobrygga', 'hydrobrygga');
INSERT INTO sted VALUES (43, 'Akerselva', 'En liten øy nedenfor gangbrua fra Bjølsen til Storo. Grunt, men rennende vann. akerselva - bjølsen', 'akerselva - bjølsen');
INSERT INTO sted VALUES (44, 'Slattum', 'Drivgress over store deler av elva. Inget bunnmeite er praktisk.', 'nitelva-enga');
INSERT INTO sted VALUES (46, 'tromøy', 'På feriehytta til Elsa Charlotte og Jarle. For en gangs skyld kan man være fornøyd med privat strandlinje! Godt fiske fra brygga, men mye båttrafikk. Båtene tar ikke hensyn til en stakkars fisker. Har man båt er det kort vei til noe mer spennende fiske på åpent hav.\r\nMormora til Tor bodde her før.\r\nNå står huset til disposisjon for festivalgjengere og en og annen fisker.', 'tromøya');
INSERT INTO sted VALUES (48, 'Skarsvatnet', 'Lavt vann mellom fjelltoppene på Åmøya skarsvatnet', 'skarsvatnet');
INSERT INTO sted VALUES (49, 'Bolgfjorden', ' bolgfjorden', 'bolgfjorden');
INSERT INTO sted VALUES (50, 'Bergstjern', 'Vann rett ved Brandbu med Abbor, Gjedde og Karuss. Vannet er landskjent for sine store Karuss. bergstjern', 'bergstjern');
INSERT INTO sted VALUES (51, 'Mjærvann', 'Vann i ved Enebakk med Gjedde og mye små abbor men også en del middels stor abbor. mjærvann', 'mjærvann');
INSERT INTO sted VALUES (52, 'Østensjøvannet', 'Et spennende sentrumsnært vann. Fiske er kun lovlig på vinteren. Rimelig garentert å få Mort, men vannet huser også fin Gjedde, Abbor og Karuss. østensjøvannet', 'østensjøvannet');
INSERT INTO sted VALUES (53, 'Breivoll', 'Midt på, utenfor sundet og nesset innerst i Bunnefjorden.', 'breivoll');
INSERT INTO sted VALUES (54, 'Misværfjorden', 'Oldereid: En plass i Misværfjorden. Dette er en såkalt terskelfjord. Det vil si at innløpet i fjorden er relativt grunt slik at artene i fjorden er lokale. Fjorden er delvis islagt om vinteren. oldereid', 'oldereid');
INSERT INTO sted VALUES (56, 'Huk', 'Temmelig grunt område med stein, sand, fjell og tang. Umulig å fiske fra på sommeren unntatt i øsende regn. huk', 'huk');
INSERT INTO sted VALUES (59, 'reine', 'Reine i Lofoten og farvannene rundt', NULL);
INSERT INTO sted VALUES (63, 'koppang', 'Et strekke av elva nord for Koppang. Ca 200 meter før kraftlinja.', NULL);
INSERT INTO sted VALUES (60, 'rondevatn', 'Ligger ved Rondvassbu i Rondane. Fra rondvassbu.com: Rondvatnet har vært fisketomt i mange år. Slik er det ikke lenger.....\r\n\r\nRondvatnet er nå fullt av røye. De 2 siste årene har det virkelig eksplodert. Røya tar nesten hva som helst, så her er det veldig morsomt å fiske, også for de små. \r\nFiskekort med vedtekter får du kjøpt på\r\nRondvassbu.', NULL);
INSERT INTO sted VALUES (58, 'indre oslofjord', 'Stort sett alle stedene som ikke ligger langs land innenfor Drøbak.', NULL);
INSERT INTO sted VALUES (72, 'sandebukta', 'Bukt med sand og mudderbunn.Her finnes små sei,hvitting og torsk men huser også store eksemplarer av småflekket rødhai.', NULL);
INSERT INTO sted VALUES (62, 'einedammen', 'Vann i Asker kjent for en liten bestand av Solabbor. Vannliljer rundet hele dammen på sommeren.', NULL);
INSERT INTO sted VALUES (64, 'svarttjønna', 'Mo i Rana', NULL);
INSERT INTO sted VALUES (65, 'ljøgodtjern', 'Lite vann ved raknahaugen på jessheim.\r\nUtmerket sted for Ørret og små karuss. Noe små abbor også. Vannet er åpent for fiske siste lørdag i august og helt til isen legger seg.', NULL);
INSERT INTO sted VALUES (67, 'drammenselva', 'Drammenselva er en fin plass med flere arter da en stor del av elva er brakkvann.Her kan man få alt fra Laks,Ørret,Skrubbe,Abor,Laue,Gjedde,Ål,Torsk osv. osv. Elva går gjennom sentrum.', NULL);
INSERT INTO sted VALUES (68, 'ingierstrand', 'Strandområde som ikke kan fiskes i badesesongen. Av arter finnes alt fra sypike til havabbor.', NULL);
INSERT INTO sted VALUES (69, 'bestemorstranda', 'Fin fiskeplass fra badebrygge. Vanskelige bunnforhold, men de lar seg mestre med riktig teknikk.', NULL);
INSERT INTO sted VALUES (70, 'hellerudsletta', 'Rett ved hyttemessa mellom kjeller og gjelleråsen. Tilrettelagt fiskeplass rett over brua og med muligheter for trasking oppover og nedover langs Nitelva', NULL);
INSERT INTO sted VALUES (73, 'sollielva', 'Elv som går fra Sollikrysset ved Sarpsborg og renner ut i Skinnerflo. Her finnes mange arter blant andre Sørv i rekordstørrelse,stam,gullbust,gjedde,gjørs osv. Fine fiskemuligheter langs hele elva men noe tett vegitasjon i sommerhalvåret.', NULL);
INSERT INTO sted VALUES (74, 'jonstrand', 'Fin plass med ner parkering. Ganske grunt. Fin vik med sandbunn, ellers stein og mudder.', NULL);
INSERT INTO sted VALUES (75, 'burøya', 'Fin halvøy ved Bodø sentrum. mudderbunn inn mot byen og sand og steinbunn ut mot hjertøy. Pass på. STRAM lukt kan forekomme.', NULL);
INSERT INTO sted VALUES (76, 'tomma', 'Øy utenfor Nesna i Nordland.', NULL);
INSERT INTO sted VALUES (78, 'ula', 'Strand utenfor Larvik med sand og tang bunn. Liten vik med store kampesteiner lengre ut. Gode bunnforhold.Obs! badestrand med mange turister og campinggjester om sommeren.', NULL);
INSERT INTO sted VALUES (79, 'visterflo', 'Ved Greåker er det nok Sørv', NULL);
INSERT INTO sted VALUES (80, 'ranelva', 'Fra saltfjellet til ranfjorden. Den øvre delen har mye ørret og noe røyr. Den nedre delen er nylig rotenonbehandlet og friskmeldt. Det er nå tatt laks på over 9 kilo.', NULL);
INSERT INTO sted VALUES (81, 'gjærsjøelva', 'Fra Gjærsjøen til første foss er det en rekke interessante kulper.', NULL);
INSERT INTO sted VALUES (82, 'piren i trondheim', '', NULL);
INSERT INTO sted VALUES (83, 'ilsvika', 'Mye nedlagt industri langs disse bryggene', NULL);
INSERT INTO sted VALUES (84, 'hitra', '', NULL);
