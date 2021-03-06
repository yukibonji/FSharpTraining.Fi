﻿namespace FSharpTraining.Exercise 
(* 
Tässä tiedostoassa on määritelty rajapinta ja testit joista toteutuksen tulisi selvitä.
 
Alussa tuloksena pitäisi olla kymmenen feilaavaa testiä. Ja kymmenen läpimenevää. 
Läpimenevät testit ovat referenssi ratkaisun testejä!

*)


(* for interactive:

 #r "Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll"

 *)
module BowlingGame =
    open Contract 
    type Game () =
        interface IGame with
            member x.Score with get() = 0 // calculate total score here
            member x.Add(pins : int) =  ()  // add new trhow to scorecard
            member x.ScoreForFrame(theFrame) = 0 // calculate total score of particular frama
    module Tests = 
        open Microsoft.VisualStudio.TestTools.UnitTesting
        [<TestClass>]
        type OOBowlingTest () =
            inherit BowlingTestsBase() 
            override x.newGame ()  = (new Game()):>IGame