<h2>Työnohjausjärjestelmä</h2>

<p>Kurssin TTOS0300 harjoitustyö</p>
Joona Korhonen / N0470@student.jamk.fi

<h2>Sisällysluettelo</h2>
1.  Sovelluksen kuvaus<br>
2.  Toimintalogiikka<br>
3.  Käytettävät teknologiat<br>
  


<h2 id="one">Sovelluksen kuvaus</h2>
<p>Tarkoituksena on tehdä työnohjausjärjestelmä työpaikoille missä työ koostuu keikoista, esimerkiksi korjaamot. 
Itselläni on henkilökohtaista kokemusta oman alani työohjausjärjestelmien riittämättömyydestä ja tästä syystä haluan tehä työnohjausjärjestelmän minkä avulla voin ainakin näyttää että asiat voi tehdä helpommin.
</p>
<p></p>

<h2 id="#two">Toimintalogiikka</h2>
<p>Yritän saada rakennettua ohjelmaan logiikan niin että ohjelma pystyy itse jakamaan työt tekijöille ja näin ollen vapauttaisi aikaa esimiehiltä.
Tekijöiden näkymä olisi yksinkertainen, missä ainoastaan näytettäisiin seuraavan keikan tiedot ja ohjelmassa olisi mahdollisuus ohittaa määrätty keikka, mutta tässä tapauksessa käyttäjän pitää kertoa mistä syystä keikka ohitetaan.
Ohjelman helppoa demoamista varten teen ohjelman SQLiteä käyttäen, mutta yritän ehtiä tekemään myös tietokantapalvelimen kanssa keskustelevan version</p>
<h3>Mahdollisia lisätoimintoja</h3>
* Keikkojen sisäänkirjaukseen oma rajoitettu näkymä ja käyttäjä luokat<br>
* mysql palvelimeen yhdistys

<h2>Käytettävät teknologiat</h2>
<p>Ohjelma toteutetaan C# ja XAML -kielillä WPF käyttäen. Tietokantana käytän lahtökohtaisesti SQLiteä, mutta pyrin myös sisällyttämään tietokantapalvelimeen yhteyden ottavan version </p>

