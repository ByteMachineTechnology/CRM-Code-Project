   M S B A M L   `   `   `  ����  CRM_User_Interface'    !CRM_User_Interface.frmAddCampaign   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  frmAddCampaign��5   	   $��403.759��6    $��720.676��61    � WindowStartupLocation$ CenterScreen=�6A    � AllowsTransparency .  � WindowStyle$
 None=�6�   .��5      �� 
���   �$��10,25,10,10q�6!   $
��Left=�6?   $	��402��6Z   $	��Top=�6g   $	��721��6   ._�5   
   � .+�5      �� -   5         ��Name$ btnClose��5      $��X��6'   $
��Left=�63   $��672,-23,-1,0q�6N   $	��Top=�6d   $��30��6|   $
��Bold"�6�   
�������6�   �� 5	      $��Campaign��6   $
��Left=�6'   $��	0,-25,0,0q�6B   $	��Top=�6U   
�������$	��188��6�   $��Verdana)�6�   $
��Bold"�6�   �� 5
      $��Campaign Name:��6   $
��Left=�6-   $��99,4,0,0q�6H   $	��Top=�6Z   $��Verdana)�6r   �� 5      -   5         ��Name$ txtSearchCampaignName��5      $
��Left=�65   $��23��6P   $��	218,6,0,0q�6\    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��261��6�   $��Verdana)�6�   6�   �� 5      -   5        $ btnDone��5      $
��Done��6&    �� 	IsDefault . $
��Left=�6F   $��	540,5,0,0q�6a   $	��Top=�6t   $��75��6�   $��24��6�   $��Verdana)�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgvCampaignDetails��5      $
��Left=�63   $��0,37,0,0q�6N   $	��Top=�6`   $	��330��6x   $	��701��6�   $��Verdana)�6�   	   GridLinesVisibility$
	 None=�6�   
   	RowHeight$
 30Q�6      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      
Visibility$ Hidden=�65      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6I   -   5        grdFinalPro_ID1��   SortMemberPath$ ID��5   n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *ID+ �� Mode$ TwoWay=�  5      $ CampaignName��6)   $	 224 6?   -   5        grdFinalPro_Name2��$ CampaignName��5   g    6�   �� *CampaignName+$ TwoWay=�  5      $ CampaignType��6)   $	 172 6?   -   5        grdFinalPro_MobileNo2��$ CampaignType��5   k    6�   �� *CampaignType+$ TwoWay=�  5      $ 
Start Date��6)   $ 85 6=   -   5        grdFinalPro_PhoneNo2��$ 	StartDate��5   g    6�   �� *	StartDate+$ TwoWay=�  5      $ End Date��6)   $ 85 6;   -	   5        grdFinalPro_Products2��$ EndDate��5   f    6   �� *	EndDate+$ TwoWay=�  5      $ Status��6)   $	 130 69   -
   5        grdFinalPro_Qty2��$ Status��5   `    6x   �� *Status+$ TwoWay=�5      �� 5      -   5        $ btnFollowupSearch��5      $
��Left=�60   $��	485,4,0,0q�6K   $	��Top=�6^   $��35��6v   $��25��6�   ���	#FFFCFCFC$��Verdana)�6�   .��5      �� $��Images/Search.ico��6   $
��Fill=�63   5      �� 5      $	��ID:��6   $
��Left=�6"   $��99,397,0,-55q�6=   $	��Top=�6S   $��Verdana)�6k   �� 5      -   5        $ txtCampaignID��5      $
��Left=�6-   $��23��6H   $��134,397,0,-53q�6T   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5      $��Campaign Name:��6   $
��Left=�6-   $��14,427,0,-85q�6H   $	��Top=�6^   $��Verdana)�6v   �� 5      -   5        $ txtCampaignName��5      $
��Left=�6/   $��23��6J   $��134,427,0,-83q�6V   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   �� 5      $��Campaign Type:��6   $
��Left=�6-   $��20,456,0,-114q�6H   $	��Top=�6_   $��Verdana)�6w   �� 5      -   5        $ txtCampaignType��5      $
��Left=�6/   $��23��6J   $��134,456,0,-112q�6V   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5       $��Start Date:��6   $
��Left=�6*   $��49,484,0,-142q�6E   $	��Top=�6\   $��Verdana)�6t   �� 5!      $��	End Date:��6   $
��Left=�6(   $��57,512,0,-170q�6C   $	��Top=�6Z   $��Verdana)�6r   (  "System.Windows.Controls.DatePicker  5"      -   5          Name$ dtpStartDate��5"      $
��Left=�6/   $��25��6J   $��135,484,0,-142q�6V   $	��Top=�6n   $	��119��6�     5#      -   5        $ 
dtpEndDate��5#      $
��Left=�6-   $��25��6H   $��135,513,0,-171q�6T   $	��Top=�6l   $	��119��6�   �� 5$      $��Status:��6   $
��Left=�6&   $��72,543,0,-201q�6A   $	��Top=�6X   $��Verdana)�6p   �� 5%      -   5        $ 	txtStatus��5%      $
��Left=�6)   $��23��6D   $��134,543,0,-199q�6P   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   5'      5(      5+      