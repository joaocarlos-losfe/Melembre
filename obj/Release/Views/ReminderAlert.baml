   M S B A M L   `   `   `  ���� C  ?Melembre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Melembre_v2.ViewsMelembre_v2.Views  %    Melembre_v2.Views.ReminderAlert   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Melembre_v2.Views     -     � Title$  Lembrando você��$	��630��$	��874�� � 
ResizeMode$ NoResize=� � ShowInTaskbar . 
������� � WindowStartupLocation$ CenterScreen=� � WindowStyle$ ThreeDBorderWindow=�
������ .����  �� Padding$ 60,30,60,30q�._��  � RowDefinitions �� �� $��9* �.+��� -    ��Name$ date_time_app��$��0��$��25(�$��Center=�$��SemiBold"����#8182A1$0��*Quinta feira, 3 de dezembro de 2020  09:00��� $��1�� �� �� �� .+��� $��0��.+��� -   $ display_reminder��$
��Wrap=�$��Center=�$	��Top=� �� TextAlignment$ Justify=�$��28(�$
��Bold"����#514F56$6��0Finalizar o trabalho de Engenharia II ate dia 23���� $��1��.+��� -   	 ��Name$	 reminder_color_priority��$��60��$��60�����#FF4841
 �� RadiusX$	
 100�� �� RadiusY$	 100���� -   $ reminder_text_priority��$��Center=�$��40(�$��SemiBold"����#514F56$��Alta prioridade���� -    ��Name$ mute_btn��$��0,10,0,0q�$��Center=�$��20(�$��Segoe MDL2 Assets)�
������ 
������ $	������ -   $ stop_button��$��3��$��Center=�$��Center=�$��20(�
������ 
������ $��0q����#6A686D$��Parar��$��342,0q�$��70��