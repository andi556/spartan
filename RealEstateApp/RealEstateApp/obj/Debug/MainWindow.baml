   M S B A M L   `   `   `  ����H  DRealEstateApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RealEstateAppRealEstateApp  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       RealEstateApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RealEstateApp     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��304��6   $	��466��6)   .��5
      � .+�5   
   �� -   5         ��Name$ ComboBoxTipLocuinta��5      $
��Left=�60   $��	10,30,0,0q�6K   $	��Top=�6^   $	��209��6v   .@�5      ��Casa��6"   ��5      
Apartament��6(   ��5      
Garsoniera��6(   ��5      
Studio��6$   5      �� 5   
   -   5         ��Name$ LabelTipLocuinta��5      $"��Selectati un tip de locuinta��6*   $
��Left=�6Q   $��10,4,0,0q�6l   $	��Top=�6~   �� 5   
   -   5        $ LabelNivele��5      $��Numar de nivele��6%   $
��Left=�6?   $��	285,4,0,0q�6Z   $	��Top=�6m    J� RenderTransformOrigin$ -0.368,-0.038&�6�   $y�Hidden=�6�   �� 5   
   -   5        $ ComboBoxNivele��5      $
��Left=�6+   $��
285,30,0,0q�6F   $	��Top=�6Z   $	��120��6r   $y�Hidden=�6~   .@�5      ��1��6   ��5      2��6   5      �� 5   
   -   5        $ LabelNumarCamere��5      $��Numar de camere��6*   $
��Left=�6D   $��	285,4,0,0q�6_   $	��Top=�6r   $ 0.553,0.231&�6�   $y�Hidden=�6�   �� 5   
   -   5        $ ComboBoxNumarCamere��5      $
��Left=�60   $��
285,30,0,0q�6K   $	��Top=�6_   $	��120��6w   $y�Hidden=�6�   .@�5      ��2��6   ��5      3��6   ��5      4��6   5      �� 5   
   -   5         ��Name$ 
CheckBoxAC��5      $��AC��6'   $
��Left=�64   $��	10,69,0,0q�6O   $	��Top=�6b   $	��100��6z   �� 5   
   -   5        $ CheckBoxPriveliste��5      $��
Priveliste��6/   $
��Left=�6D   $��	10,89,0,0q�6_   $	��Top=�6r   �� 5   
   -	   5        $ CheckBoxGaz��5      $	��Gaz��6(   $
��Left=�66   $��
10,109,0,0q�6Q   $	��Top=�6e   �� 5    
   -
   5        $ CheckBoxUtilitatiSmart��5       $��Utilitati Smart��63   $
��Left=�6M   $��
10,129,0,0q�6h   $	��Top=�6|   �� 5!   
   -   5        $��Calculeaza totalul��5!      $
��Left=�6.   $��173,159,0,0q�6I   $	��Top=�6^   $	��100��6v   6�   �� 5"   
   -   5        $ LabelTotalPret��5"      $��Total pret locuinta:��6(   $
��Left=�6G   $��
12,201,0,0q�6b   $	��Top=�6v   $	��134��6�   $��14(�6�   $y�Hidden=�6�   �� 5#   
   -   5        $ 
LabelTotal��5#      $��Label��6$   $
��Left=�64   $��173,204,0,0q�6O   $	��Top=�6d   $	��100��6|   $
��Bold"�6�   $y�Hidden=�6�   5%      5&      