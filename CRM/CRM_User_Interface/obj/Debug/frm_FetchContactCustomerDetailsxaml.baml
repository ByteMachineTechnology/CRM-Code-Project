   M S B A M L   `   `   `  ����  CRM_User_Interface<    6CRM_User_Interface.frm_FetchContactCustomerDetailsxaml   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  frmCRM_ContactDetails��5   
   $	��448��6(   $��988.415��65    � AllowsTransparency .  � WindowStyle$
 None=�6_   
������  � WindowStartupLocation$ CenterScreen=�6�   .��5      �� 
���   �$��10,20,10,15q�6!   $	��446��6?   $	��Top=�6L    �� CornerRadius$ 10��6d   ._�5   
   � -   5         �Name$ grdSaleContactDeatils��5      $y�Visible=�6.   $
��Left=�6H   $	��400��6c   $��0,5,0,-5q�6p   $	��Top=�6�   $	��968��6�   ���	#FFF0F0F0.+�5      �� -   5         ��Name$! btnAdm_ContactCDetails_Exit��5      $
��Exit��6:   $
��Left=�6I   $��	893,2,0,0q�6d   $	��Top=�6w   $��65��6�   $��24��6�   6�   �� 5	      $��Contact Customer Details��6   $
��Left=�67   $��2,0,0,0q�6R   $	��Top=�6c   $
��Bold"�6{   $��20(�6�   $	��330��6�   � 5
      $��	8,31,10,0q�6   
�������.+�5      �� -   5        $��grpDealer_Search4��5   +   $��Search��6   $
��Left=�6D   $	��Top=�6_   $	��950��6w   $��64��6�   .��5      � $	��Top=�6   $��44��64   ���	#FFF0F0F0.+�5      �� $��Enter First Name:��6    $
��Left=�6<   $��6,5,0,0q�6W   $	��Top=�6h   $	��106��6�   �� 5      -   5         ��Name$ txtFCnt_FName��5   "   $��23��69   $��114,8,643,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   6�   �� 5      $��Contact ID:��6    $
��Left=�66   $��	575,8,0,0q�6Q   $	��Top=�6d   $��82��6|   �� 5      -   5        	 ��Name$	 cmb_FCnt_EID��5   #   $
��Left=�69   $��
662,10,0,0q�6T   $	��Top=�6h   $	��165��6�   
 �� 
IsEditable
 . $��24��6�   6�   �� 5      -   5        $ btnFCnt_Refresh��5   !   $��Refresh��6:   $
��Left=�6L   $��
843,13,0,0q�6g   $	��Top=�6{   $��68��6�   �� 5      $��Enter Last Name:��6    $
��Left=�6;   $��	302,8,0,0q�6V   $	��Top=�6i   $	��106��6�   �� 5      -   5        $ txtFCnt_LName��5   "   $��23��69   $��406,10,367,0q�6E   $
 Wrap=�6[   $	��Top=�6o   6�   �� 5      -	   5        $ 	txtFCntID��5   "   $��23��65   $��551,-48,367,0q�6A   $
 Wrap=�6X   $	��Top=�6l   �� 5      -
   5        $ txtFCntName��5   "   $��23��67   $��580,-48,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $
��Left=�6�   $	��193��6�   5      5      &   System.Windows.Controls.DataGrid  5      -   5          Name$  dgvSale_ContactCustDetails��5      $��6,60,2,0q�6?   $	��Top=�6Q   $	��299��6i      AutoGenerateColumns .     	RowHeight$ 25Q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 69   -   5        grdFinalProID��   SortMemberPath$ Domain_Name��5!   \   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6y   �� *ID+ �� Mode$ TwoWay=�  5"      $ ContactCustID��6-   $	 110 6D   -   5        grdContactCustID��$ ContactCustID��5"   k    6�   �� *ContactCustID+$ TwoWay=�  5#      $ 
First Name��6-   $	 180 6A   -   5        grdFirstName��$ 	FirstName��5#   d    6   �� *	FirstName+$ TwoWay=�  5$      $ LastName��6-   $	 180 6?   -   5        grdLastName��$ LastName��5$   a    6{   �� *
LastName+$ TwoWay=�  5%      $ MobileNo��6-   $	 150 6?   -   5        grdMobileNo��$ MobileNo��5%   a    6{   �� *
MobileNo+$ TwoWay=�  5&      $ EmialID��6-   $	 150 6>   -   5        
grdEmialID��$ EmialID��5&   _    6x   �� *	EmialID+$ TwoWay=�  5'      $ Address��6-   $	 180 6>   -   5        grdMailingStreet��$ MailingStreet��5'   e    6�   �� *MailingStreet+$ TwoWay=�5)      5*      �� 5+      -   5        $ txtCCDID��5+      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��	376,3,0,0q�6�   5/      50      51      