   M S B A M L   `   `   `  ���� C  ?Melembre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Melembre_v2.ViewsMelembre_v2.Views      Melembre_v2.Views.Edit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Melembre_v2.Views       � Title$  Editar lembrete��$	��630��$	��874�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$ SingleBorderWindow=�
�������.����  �� Padding$ 30q�._��  � ColumnDefinitions �� ��  � RowDefinitions �� $	��20* ��� $��2* �.+�� $��0�� �� �� �� .+��� $��0��$��5,0,5,0q�.+��� $��16(�$��SemiBold"����#514F56$��Digite o Lembrete���� -    ��Name$ 	input_txt�� �� TextWrapping$
 Wrap=�	 �� MaxLines$	 3��
 �� 	MaxLength$	
 120�� �� TextAlignment$ Justify=�$��0,14,0,0q�$��18(�$��90��
���   �$��SemiBold"�$��5q�
�������$��2q�.���� $��1��$��5,0,5,0q�.+��� $��16(�$��SemiBold"����#514F56$��
Prioridade���� $��14(�$��SemiBold"����#9A9A9A$
��Wrap=�$=��7Clique em uma cor desejada para definir uma prioridade.���  �� �� �� ��  �� Orientation$ 
Horizontal=�$��0,20,0,0q�.+��� -    ��Name$ high_btn��$��5q�
������ 
������ .���� $ Vertical=�.+��� $��30��$��30�� �� RadiusX$	 100�� �� RadiusY$	 100�����#FF4841$	��Top=�$��Center=��� $��18(�$��SemiBold"����#514F56$
��Alta��$��Center=�$��Bottom=��� -   $ average_button��$��50,0,0,0q�$��5q�
������ 
������ .���� $ Vertical=�.+��� $��30��$��30��$	 100��$	 100�����#FBB452$	��Top=�$��Center=��� $��18(�$��SemiBold"����#514F56$��Média��$��Center=�$��Bottom=��� -   $ 
low_button��$��50,0,0,0q�$��5q�
������ 
������ .���� $ Vertical=�.+��� $��30��$��30��$	 100��$	 100�����#99EFD5$	��Top=�$��Center=��� $��18(�$��SemiBold"����#514F56$��Baixa��$��Center=�$��Bottom=��� $��2��$��	0,30,0,40q�.+��� $��14(�$��SemiBold"����#9A9A9A$��Prioridade definida��� -    �Name$ selected_color_priority��$��0,14,0,0q�$��53��$	��175��$
��Left=����#FF4841.+��� -    ��Name$ selected_text_priority��$
��Alta��$��Center=�$��Center=�$��18(�$��SemiBold"�
�������� $��1��$��50,0,0,0q� �� �� �� .+��� $��0��$��5,0,5,0q�.+��� $��16(�$��SemiBold"����#514F56$��	Categoria���� -    ��Name$ category_selected��$��0,14,0,0q����#F9F9F9
������ $��0q�$��SemiBold"�$��18(�$��Center=�$	��100��.@��� $��social�� �� 
IsSelected . �� $��medicação���� $��lazer���� $��
financeiro���� $��consulta���� $��estudos���� $��medico���� $��contas���� $��trabalho���� -   $ OutroBtn��$	��350��$��Outro...��
������ $��0q��� $��1��$��5,0,5,0q�.+��� $��16(�$��SemiBold"����#514F56$��Frequência���� -	   $ frequency_select��$��0,14,0,0q����#F9F9F9
������ $��0q�$��SemiBold"�$��18(�$��Center=�$	��100��.@��� $��Uma vez�� . �� $��Todo dia���� -
   $ SelectDaysBtn��$	��350��$��16(�$��Definir dias....��
������ $��0q��� $��2��$��5,30,5,0q�.+��� $��16(�$��SemiBold"����#514F56$��
Lembrar as��� $��0,14,0,0q� �� �� .+��� $��0��$��0,0,5,0q�.+��� $��14(�$��SemiBold"����#9A9A9A$
��Hora���� -   $ hour_select�����#F9F9F9
������ $��0q�$��SemiBold"�$��18(�$��Center=�$	��100��.@��� $��12�� . �� $��1��$��5,0,0,0q�.+��� $��14(�$��SemiBold"����#9A9A9A$��	Minuto(s)���� -   $ minut_select�����#F9F9F9
������ $��0q�$��SemiBold"�$��18(�$��Center=�$	��100��.@��� $��00�� . �� -   $ save_buttom��$��1��$��2��$��Center=�$��Center=�$��30(�
������ 
������ $
��Bold"����#6A686D$��Salvar��