   M S B A M L   `   `   `  ���� D  @BetterWay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BetterWay.ViewsBetterWay.Views  "    BetterWay.Views.LogisticView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:BetterWay.Views       � 	Resources     partInfo �� Orientation��%F   &	        �� .R��� $ 
Horizontal=�.+��� ���� *
PartInfo+.��� .+���  �� TabStripPlacement$
 Left=�.@��� $��Etusivu��.���� -   .+��� -    ��Name$ 
txbWelcome��$��35(����� �� $��
Luo keikka��.���� .+��� $	 Top=�.@��� $��Jälleenmyyjän tiedot��.���� .+��� $��Valitse jälleenmyyjä: ���� $ 
Horizontal=�.+��� -    ��Name$ 
cmbDealers������ �� -    ��Name$ btnAddDealer��$��Lisää jälleenmyyjä���� $��Nimi: ���� -   $ txbDealerName���� $��Osoite: ���� -   $ txbDealerAddress���� $��
Kaupunki: ���� -   $ txbDealerCity���� $��Postinumero: ���� -   $ txbPostcode���� $��Puhelin numero: ���� -	   $ txbDealerPhone���� $��Email: ���� -
   $ txbEmail���� -   $ btnEditDealer��$'��!Päivitä jälleenmyyjän tietoja���� $��Asiakkaan tiedot��.���� .+��� $��Valitse asiakas: ���� $ 
Horizontal=�.+��� -   $ cmbCustomers������ �� -   $ btnAddCustomer��$��Lisää asiakas���� $��Nimi: ���� -   $ txbCustName���� $��Osoite: ���� -   $ txbCustAddress���� $��
Kaupunki: ���� -   $ txbCustCity���� $��Postinumero: ���� -   $ txbCustPostcode���� $��Puhelin numero: ���� -   $ txbCustPhone���� $��Email: ���� -   $ txbCustEmail���� -   $ btnEditCustomer��$!��Päivitä asiakkaan tietoja���� -   $��Laitteen tiedot��.���� .+��� $ 
Horizontal=�$��5 5 0 0q�.+��� $��Merkki: ��$��75���� -   $ cmbBrand��$	��100������ �� $ 
Horizontal=�$��5 5 0 0q�.+��� $��Malli: ��$��75���� -   $ cmbModel��$	��100��$��0 0 5 0q��� -   $ btnAddModel��$��Lisää malli���� $ 
Horizontal=�$��5 5 0 0q�.+��� $��Sarjanumero:��$��75���� -    ��Name$ 	txbSerial��$	��100���� $ 
Horizontal=�$��5 5 0 0q�.+��� $��Ostopäivä: ��$��75��(  "System.Windows.Controls.DatePicker  -     Name$ dpPurchaseDate��   IsTodayHighlighted . $	��100���� $ 
Horizontal=�$��5 5 0 0q�.+��� $��Takuu: ��$��75���� -   $ cmbWarranty��$	��100��.@��� $��Kyllä���� $��Ei���� $��Viankuvaus: ���� -   $ txbFault��$	��150���� -   	 ��Name$	 
tiOverview��$��
Yhteenveto��.���� .+��� $ 
Horizontal=�.+��� $��Jälleenmyyjä: ��$��15(�$
��Bold"��� -   $ txtDealerName���� $ 
Horizontal=�.+��� $��	Asiakas: ��$��15(�$
��Bold"��� -   $ txtCustomerName���� $ 
Horizontal=�.+��� $��Laite: ��$��15(�$
��Bold"��� -    $ txtUnit���� $ 
Horizontal=�.+��� $��Vian kuvaus: ��$��15(�$
��Bold"��� -!   $ txtFault���� $ 
Horizontal=�.+��� $��Takuu: ��$��15(�$
��Bold"��� -"   $ txtWarranty���� -#   $ 
btnAddCase��$��
Luo keikka���� $��Varaosat��.���� -$   .+��� -%   
 ��Name$
 lsvOrderedParts��#��[  ���� 