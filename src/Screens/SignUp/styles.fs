module App.Screens.SignUp

open Fss
open App
open Design
open Fss.Types

let private container =
    [ Width.value (vw 100)
      MaxWidth.value (vw 100)
      MinHeight.value (vh 80)
      TextAlign.center ]

let private formBox =
    [ yield! GlobalStyles.MarginAuto
      MaxWidth.value (px 312)
      Height.value (px 340)
      MarginBottom.value (px 24)
      Display.flex
      FlexDirection.column
      JustifyContent.spaceBetween ]

let private buttonWrapper =
    [ yield! GlobalStyles.MarginAuto
      Display.flex
      Width.value (px 148)
      MinHeight.value (px 250) ]

let private button =
    [ yield! GlobalStyles.Button
      BoxSizing.borderBox
      MinWidth.value (pct 100)
      MaxHeight.value (px 40)
      VerticalAlign.middle ]

let styles =
    {| container = container
       formBox = formBox
       buttonWrapper = buttonWrapper
       button = button |}
