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
2016-04-08 AN_20160513_8351_BD_Docman Fouten Fix.docx \\wds-srv\Stagiairs_IT\Bert\Stage Tickets\Docman\AN_20160513_8351_BD_Docman Fouten Fix.docx