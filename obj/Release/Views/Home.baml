   M S B A M L   `   `   `  ���� C  ?Melembre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Melembre_v2Melembre_v2      Melembre_v2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Melembre_v2     -     � Title$  Melembre��$	��600��$
��1150��$	��634��$
��1222�� � WindowStartupLocation$ CenterScreen=�.����  �� Padding$ 
30,5,30,30q�
�������._�� 
������� � RowDefinitions �� $��1* ��� $	��13* �.+��� -    ��Name$ add_btn��
������ 
������ $��0q� � ToolTip$ Adiocina um novo lembrete��$��0��$
��Left=�$��10q�.����  �� Orientation$ 
Horizontal=�.+��� $��Segoe MDL2 Assets)�$	����$��14(�$��Center=��� $��5,0,0,0q�$��Adicionar lembrete��$��14(�$��Center=��� $��0��$��Center=�$��Right=�$ 
Horizontal=�.+��� ���#8182A1$��Segoe MDL2 Assets)�$	����$��14(�$��Center=��� -    ��Name$ date_time_app��$ Data e hora atual��$��5,0,0,0q����#8182A1$�� ��$��14(�$��Center=��� $��0��$ 
Horizontal=�$��Center=�$��Center=�.+��� -   $ delete_button��$y�Hidden=�$. (Exclui o lembrete atualmente selecionado��
������ 
������ $��0q�$��10q�.���� $ 
Horizontal=�.+��� $��Segoe MDL2 Assets)�$	����$��16(�$��Center=��� -   $ edit_button��$y�Hidden=�$- 'Edita o lembrete atualmente selecionado��
������ 
������ $��0q�$��10q�.���� $ 
Horizontal=�.+��� $��Segoe MDL2 Assets)�$	����$��16(�$��Center=��� -   $ conclude_button��$y�Hidden=�$2 ,Marcar o lembrete selecionado como concluido��
������ 
������ $��0q�$��10q�.���� $ 
Horizontal=�.+��� -   $ icon_concluded��$	��✔��$��16(�$��Center=��� -    ��Name$ reminders_list_view��$��0,10,0,0q�	 �� SelectionMode$	 Single=�$��1��
������ $��0q�$��Center=�
 � 	Resources
  �� 
TargetType �� Property �� Value��%�   '��       �� " ��.���  � ��$
 Left=���  � �� �#514F56��  � ��$ 14(���  � ��$ 	10,5,10,5q���  � ��
 �������  � ��
 �������  � ��$ 0,0,0,0q� �� View ��  �� AllowsColumnReorder .  .P��� $��
Prioridade�� �� Width$	 200�� �� CellTemplate �� .R��� $ 
Horizontal=�$��2q�.+���  �� RadiusX$	 100�� �� RadiusY$	 100��$��25��$��25��$��2q����� *Priority_color+�� $��Center=�$��10,0,0,0q�$��SemiBold"�$��18(����� *
Priority+�� $��Lembrete��$	 350�� �� .R��� $��	0,15,0,15q�$��18(� �� TextAlignment$ Justify=�$��SemiBold"����#514F56$
��Wrap=����� *Reminder_text+�� $��	Concluido��$	 200�� �� .R��� $ 	concluido��$��5q�$ Justify=�$��
ExtraBlack"�$
��Wrap=�$��30(����� *Concluded_color+���� *Concluded_text+�� $��	Categoria��$	 150�� �� .R��� $��5q�$��SemiBold"�$��18(����� *
Category+�� $��
Lembrar as��$	 150�� �� .R��� $��5q�$��SemiBold"�$��18(����� *
_Horario+�� $��Frequência��$	 200�� �� .R��� $��5q�$��SemiBold"�$��18(����� *	Frequency+