   M S B A M L   `   `   `  ���� S  Otaglib-sharp, Version=2.0.3.7, Culture=neutral, PublicKeyToken=db62eba44689b5b05*clr-namespace:TagLib;assembly=taglib-sharpTagLib  
 MWMPV2   MWMPV2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =TagLib*clr-namespace:TagLib;assembly=taglib-sharp     -     �Name$  MainWindow1�� � Title$  My Windows Media Player V2��$��491.168��$��621.484��
���   � � 	Resources  !  SliderThumb.Static.Foreground �� Color $  SliderThumb.MouseOver.Background   SliderThumb.MouseOver.Border " SliderThumb.Pressed.Background  SliderThumb.Pressed.Border # SliderThumb.Disabled.Background  SliderThumb.Disabled.Border ! SliderThumb.Static.Background  SliderThumb.Static.Border 	 SliderThumbHorizontalTop �� 
TargetType � UseLayoutRounding F�Name �� Stretch J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value �� 
TargetName �� Value �� Property 
 SliderThumbHorizontalBottom  SliderThumb.Track.Border   SliderThumb.Track.Background  RepeatButtonTransparent �� 
TargetType   SliderThumbHorizontalDefault  SliderHorizontal ��Name � RowDefinitions m�Name m� Fill m� 	Placement ��Name ]�Name ]� DecreaseRepeatButton �� DecreaseLarge ]� IncreaseRepeatButton �� IncreaseLarge ]� Thumb n�Name � OverridesDefaultStyle J� OpacityMask  SliderThumbVerticalLeft  SliderThumbVerticalRight  SliderThumbVerticalDefault  SliderVertical � ColumnDefinitions  MySlider  �� Triggers��%�  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     &	 �     &		 �     7  7  7  7  7  7  7  7  &	
 �    7  7  7  7  7  7  7  7  &	 �    &	 �    &	     &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7 	 7 
 &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  &	 T    7  7  7  7  7  7  7  &	 7    7   7  7  �� $ 	#FFE5E5E5���� $ 	#FFDCECFC���� $ 	#FF7Eb4EA���� $ 	#FFDAECFC���� $ 	#FF569DE5���� $ 	#FFF0F0F0���� $ 	#FFD9D9D9���� $ 	#FFF0F0F0���� $ 	#FFACACAC���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������    ��[ �    ��[ `�S `�S �`�S     �ا ��[ �ا ��[ ��ا ��[ �ا ���ا ����ا �������    ����[ ��[ 	8��  $
 Fill=� . 8�� $��1�� . $��Center=�	 P� 
 �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip�������     � �     � `�S ��`�S ���`�S ���ا  � �ا  � ��ا  � �ا �ا ��ا     �         �  � 	8��  $
 Fill=� . 8�� $��1�� . $��Center=�	 P� 
 �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� $ 	#FFD6D6D6���� $ 	#FFE7EAEA���� " ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� #��z��#��z��#��z���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip��d����        �        �ا �ا ��ا     �ا ���ا ����ا �������    ��	8��  $
 Fill=� . 8�� $��1�� . $��Center=�	 P� 
 �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._��  �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�m� $ TopTick��# z��$��4��$��0,0,0,2q�$	 Top=�$��0��$y�	Collapsed=�m� $ 
BottomTick��# z��$��4��$��0,2,0,0q�$ Bottom=�$��2��$y�	Collapsed=��� $ TrackBackground�����	#FF009BDC$��1q����	#FF00B4FF$	��4.0��$	��5,0q�$��1��$��center=�._��� $��-6,-1q�.+��� $ PART_SelectionRange��#��� ��$	��4.0��$y�Hidden=�]� $ 
PART_Track��$��1�� �� #��Z 8��   �� #��Z 8��  n� $ Thumb��|�.  $��11�� . 8�� $��Center=�$��11�����	#FF00B4FF���	#FF00B4FF��Z�  Z� 	 P� 
 �@��TickPlacement$ TopLeft=�. ��� $ TopTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 5,2,5,0q�P� 
 �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 5,0,5,2q�P� 
 �@��TickPlacement$
 Both=�. ��� $ TopTick�� � y�$ Visible=��� $ 
BottomTick�� � y�$ Visible=�P� 
 �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange�� � y�$ Visible=�P� 
 �@J�IsKeyboardFocused . . ��� $ Thumb�� � ��
 ��  ��� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip���������[ �ا Ӏ�[ �ا `�S `�S �    `�S ��[ ��[ Ӏ�[     ����Ӏ�    ���ا ���ا Ӏ��ا ��[ �ا ��[ �ا 	8��  $
 Fill=�8�� 	 P� 
 �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip������� � �ا � � �ا ��`�S ��`�S Ӏ�`�S  �  � � �     �        �ا �ا �    �ا  � �ا  � �ا 	8��  $
 Fill=�8�� 	 P� 
 �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " n�.R�� $��Center=� . $��Center=�.+�F� $
 grip��+���� �  � ѠI � ѠI�y� � � �y� 	8��  $
 Fill=�8�� 	 P� 
 �@J�IsMouseOver . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 �@n�
IsDragging . . ��� $
 grip��8   � ���� $
 grip��8   � ��P� 
 � {� .  . ��� $
 grip��8   � ���� $
 grip��8   � ���� " ��.R��� $ border��#��z��#��z��#��z�� . ._��  �� $
��Auto ��� #��z��$
��Auto ��� $
��Auto �.+�m� $ TopTick��$��0��# z��$��0,0,2,0q�$
 Left=�$y�	Collapsed=�$��4��m� $ 
BottomTick��$��2��# z��$��2,0,0,0q�$ Right=�$y�	Collapsed=�$��4���� $ TrackBackground��8��  $��1q�8�� $��1��$��center=�$	��0,5q�$	��4.0��._��� $��-1,-6q�.+��� $ PART_SelectionRange��#��� ��$y�Hidden=�$	��4.0��]� $ 
PART_Track��$��1�� �� #��Z 8��  �� #��Z 8��  n� $ Thumb��|�.  $��11�� . 8�� $	��Top=�$��18��	 P� 
 �@��TickPlacement$ TopLeft=�. ��� $ TopTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 2,5,0,5q�P� 
 �@��TickPlacement$ BottomRight=�. ��� $ 
BottomTick�� � y�$ Visible=��� $ Thumb��8   � ���� $ TrackBackground�� � ��$ 0,5,2,5q�P� 
 �@��TickPlacement$
 Both=�. ��� $ TopTick�� � y�$ Visible=��� $ 
BottomTick�� � y�$ Visible=�P� 
 �@��IsSelectionRangeEnabled . . ��� $ PART_SelectionRange�� � y�$ Visible=�P� 
 �@J�IsKeyboardFocused . . ��� $ Thumb�� � ��
 ��  ��� " ��.���  �@��IsPressAndHoldEnabled .  ��  � ��
 ���� ��  � ��
 ���� ��  � ��8   ��  � ��8    P� 
 �@��Orientation$ Vertical=�. ���  � ��8  .���  ��  �� .+�r� -   ! r�Name$! MElem��$��Center=�$��0q�$	��Top=�" J� RenderTransformOrigin$	" 1,1&�# r� LoadedBehavior$# Manual=��� -   $ ��Name$$ 
MainCanvas��$��Center=�$	��117��$��	50,0,51,0q�$��Bottom=�$	��512������ % �� EndPoint$% 0.5,1&�& � MappingMode$& RelativeToBoundingBox=�' �� 
StartPoint$' 0.5,0&�.��� ( � Color$( 	#00000000��� $( Black��) � Offset$) 1Q�.+��� -   * ��Name$* btn_Open��$�� ��$��Center=�$��Bottom=�$��45��$��45��
+ �� Top$+ 33��, �� Left$	, 165��  MetroButton#���  
���   ���Z� ���� - �� ImageSource$- Images/OpenHD.png��. j� Stretch$. Uniform=��� -   $* btn_Stop��$�� ��$��Center=�$��Bottom=�$��45��$��45��$	, 115��$+ 33��#���  ��Z� ���� $- Images/StopHD.png��$. Uniform=��� -   $* btn_Play��$�� ��$��Center=�$��Bottom=�$��45��$��45��$, 15��$+ 33��#���  ��Z� ���� $- Images/PlayHD.png��$. Uniform=��� -   $* 	btn_Pause��$�� ��$��Center=�$��Bottom=�$��45��$��45��$, 65��$+ 33��#���  ��Z� ���� $- Images/PauseHD.png��$. Uniform=��� -   / ��Name$/ VSlide��$��Center=�$��Bottom=�$��18��$	��492��$, 10��$+ 10��0 �� IsMoveToPointEnabled0 . 
�������#���  ��Z� �� -	   $/ VolSlide��$��Center=�$��Bottom=�$��82��$��18��1 � Maximum$1 1Q�2 � Value$	2 100Q�$	, 420��$+ 44.667��#���  �� -
   $* Btn_FullScreen��$�� ��$	, 215��$+ 33��$��45��$��45��#���  ��Z� ���� $- Images/FullscreenHD.png��$. Uniform=��� -   $* 
Btn_Repeat��$�� ��$	, 265��$+ 33��$��45��$��45��#���  ��Z� ���� $- Images/RepeatHD.png��$. Uniform=��� -   $* Btn_Lib��$�� ��$	, 315��$+ 33��$��45��$��45��#���  ��Z� ���� $- Images/PlaylistHD.png��$. Uniform=��� -   3 ��Name$3 	Lbl_Title��$��Title��$, 22��$+ 83��$" 0.544,0.526&����	#FF00B4FF�� -   $$ 	LibCanvas��$��Right=�$	��306��$��0,10,0,0q�$	��Top=�$	��291������ $% 0.5,1&�$& RelativeToBoundingBox=�$' 0.5,0&�4 �� RelativeTransform4 V� .~��� 5 �� CenterY$	5 0.5Q�6 �� CenterX$	6 0.5Q��� 7 �� CenterY$	7 0.5Q�8 �� CenterX$	8 0.5Q��� 9 �� Angle$9 92Q�: �� CenterY$	: 0.5Q�; �� CenterX$	; 0.5Q�T� .��� $( Black��� $( 	#00000000��$) 1Q�.+��� -   < ��Name$< Library��$	��246��$, 10��$+ 50��$	��271��$
��Bold"���Z� ���� .R��� ���� *	Message+���� *MessageColor+= � DataContext=    TagLib.MediaTypes None=��� -   $* Btn_Add��$�� ��$, 10��$+ 5��$��45��$��45��#���  $" 1.615,-3.644&���Z� ���� $- Images/PlusHD.png��$. Uniform=��� -   $* Btn_Prev��$�� ��$, 60��$+ 5��$��45��$��45��#���  $" 1.615,-3.644&���Z� ���� $- Images/PrevHD.png��$. Uniform=��� -   $* Btn_Next��$�� ��$	, 110��$+ 5��$��45��$��45��#���  $" 1.615,-3.644&���Z� ���� $- Images/NextHD.png��$. Uniform=��� -   $* Btn_Save��$�� ��$	, 160��$+ 5��$��45��$��45��#���  $" 1.615,-3.644&���Z� ���� $- Images/SaveHD.png��$. Uniform=��� -   $* Btn_Load_Playlist��$�� ��$	, 210��$��45��$��45��#���  $" 1.615,-3.644&�$+ 5����Z� ���� $- Images/OpenHD.png��$. Uniform=�