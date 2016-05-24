##Document Manager

Handleiding:
Ik heb deze applicatie niet geschreven en maar even bekeken voor een patch.

GlobaalPassword is boss

#Nodig: 
* .NET 2.0 / .NET 3.5
* Microsoft Office (2010? 32bit?)
	Voor References:
	- VBIDE
	- Word
	- MTGCCombobox

Door de bloated reference van MTGCCombobox wil je option strict off (anders krijg je extreem veel warnings / errors).

#CODE STYLE

1. Gebruik een prefix bij visuele elementen op een form: txtPasswoord
   Niet noodzakelijk voor items die dynamisch toegevoegd worden, dit is om clutter te voorkomen.
2. Gebruik zo weinig mogelijk DOCUMENTMANAGEMENT COMPONENTS op een form.
   Er is geen reden om deze op de form toe te voegen in plaats van in de code. 
   Zo weet je niet wat waar gebruikt wordt!
   Dit 'ontcluttert' de codebase ook
3. Gebruik CamelCase of PascalCase in je code.
   Deze zijn door de jaren heen door elkaar gebruikt.
4. Nieuwe MTGCComboBox form items toevoegen is verboden. Maak de noodzakelijke classes aan om dezelfde logica
   met veiligere functionaliteit te bekomen.
5. Maak je code leesbaar: gebruik comments en gebruik geestelijk gezonde variabel namen
6. Niet gebruikte code verwijder je
	(Lijnen als 'You can remove, delete or change this code it doesn't matter) helpen niet
7. Hou je changes bij (ik heb ze in docman bijgehouden)


#Changes
(Onder Docman naam Didier Boydens)
Docman ID: 8351
Titel: Docman Fouten Fix.docx 
Een verslag met bugs te fixen, hoe ik ge opgelost heb, en opmerkingen over het programma.

#Versioning
Bij elke (grote) publicatie van het programma wil je deze stappen doorlopen:
1. Maak Patch notes (voorbeeld: docman ID: 8388)
2. Verander de titel (visueel) van de forms
3. Zet de patch notes op een publieke share (liefst zoals de vorige auteur gedaan heeft voor consistentie)
4. Verander 'ApplicatieInstellingen.vb' (DocmanVersie, DocmanPatchNotesPad)
5. Controleer of je via Main > Tab: Configuratie > De juiste info krijgt en of je er op kunt klikken
6. Publish
