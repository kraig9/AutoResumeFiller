   M S B A M L   `   `   `  ���� K  GAutoResumeFiller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AutoResumeFillerAutoResumeFiller  !    AutoResumeFiller.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:AutoResumeFiller       � Title$  ResumeFiller��$��856.452��$	��800��.��� $��0,0,-298,-364q� � ColumnDefinitions �� .+��� -    ��Name$ label��$:��4I'm tired of filling out resumes and cover letters
��$
��Left=�$	��Top=�$��56��$	��355���� -    ��Name$ textBox��$
��Left=�$��91��$��	52,92,0,0q� �� TextWrapping$
 Wrap=�$��Company name here
��$	��Top=�$	��149���� -   $ label1��$��Company name here

��$
��Left=�$	��Top=� J� RenderTransformOrigin$ 2.069,2.311&�$	��137��$��	52,61,0,0q�$��26���� -   $ textBox1��$
��Left=�$	��524��$��
52,267,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��660���� -   $ label2��$��Cover letter <.<��$
��Left=�$��
52,223,0,0q�$	��Top=�$	��120��$ 0.566,3.021&��� -   $ label3��$��Position applying for��$
��Left=�$	��Top=�$ 	5.625,3.9&�$��
311,69,0,0q�$	��134���� -   $ textBox2��$
��Left=�$��83��$
 Wrap=�$ ��Position applying for here��$	��Top=�$	��200��$��311,100,0,0q��� -    ��Name$ openFile��$��File Picker
��$
��Left=�$	��Top=�$��73��$��600,100,0,0q��� -	    ��Name$ 	textBlock��$
��Left=�$��
600,74,0,0q�$
��Wrap=�$	��Top=�$	��112���� $�Pick cover letter���� �� 