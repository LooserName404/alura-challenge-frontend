﻿[<RequireQualifiedAccess>]
module App.MediaQueries

open Fss

let Mobile =
    [ Fss.Types.Media.MaxWidth(px 767) ]

let MobileMediaQueryString =
    "(max-width: 767px)"

let Tablet =
    [ Fss.Types.Media.MinWidth(px 768)
      Fss.Types.Media.MaxWidth(px 1023) ]

let Desktop =
    [ Fss.Types.Media.MinWidth(px 1024) ]