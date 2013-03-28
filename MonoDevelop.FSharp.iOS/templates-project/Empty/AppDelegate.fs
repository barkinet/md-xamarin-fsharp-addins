namespace ${Namespace}

open System
open MonoTouch.UIKit
open MonoTouch.Foundation

// The UIApplicationDelegate for the application. This class is responsible for launching the 
// User Interface of the application, as well as listening (and optionally responding) to 
// application events from iOS.
[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit UIApplicationDelegate ()

    // create a new window instance based on the screen size
    let window = new UIWindow (UIScreen.MainScreen.Bounds)

    // create your root view controller
    //let rootViewController = new MyViewController ()

    //
    // This method is invoked when the application has loaded and is ready to run. In this 
    // method you should instantiate the window, load the UI into it and then make the window
    // visible.
    //
    // You have 17 seconds to return from this method, or iOS will terminate your application.
    //
    override x.FinishedLaunching (app: UIApplication, options: NSDictionary) =
        // If you have defined a root view controller, set it here:
        //window.RootViewController <- rootViewController

        // make the window visible
        window.MakeKeyAndVisible ()
        true

module Main =
    [<EntryPoint>]
    let main (args) =
        UIApplication.Main (args, null, "AppDelegate")
        0
