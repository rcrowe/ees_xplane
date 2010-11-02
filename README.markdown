# EES Xplane

This project creates a networked IOS (Instructor Operating Station) for controlling the environment inside of [Xplane](http://www.x-plane.com/index_desktop.html). It was built over a week to help 6th form students from a local school learn about Thales Training and Simulation, Engineering, Programming/Software and putting a large project together, as part of the [Engineering Education Scheme(EES)](http://www.engineering-education.org.uk/).

There task was to produce an instructors station for the Xplane flight simulator using blue sky thinking, new technologies not currently implemented by us, such as METARs and then produce a prototype.

* [EES](http://www.engineering-education.org.uk/)
* [Xplane](http://www.x-plane.com)

## Components

The application is split up into 5 sections to allow the system to be run across a network. This has been done to separate graphic intensive operations from the IOS. The IOS can then run on multiple machines to make use of 2+ touch screen monitors.

When running the IOS and Xplane you do not need to concern your self with the architecture of the network. Just start the clients on the same network and vlan.

Components:

* `IOSees_Xplane` - The actual Xplane plugin. Written in C. C# client calls extern functions of plugin.
* `IOSees_Server` - Handles all communications between the clients.
* `IOSees_Master` - Main IOS screen, controlls which screen `IOSees_Slave` displays.
* `IOSees_Slave`  - Main IOS pages for controlling simulation environment.
* `IOSees_Plugin` - Must be on the same machine as `IOSees_Xplane`. Communicates with Xplane plugin.


Folders
-------

* `IOSees`

	- Contains the bulk of the files needed to run the IOS

	- No configuring of IP address, should be handled if network is set up correctly. 
          Make sure that all PCs being used can see each other and are in the same           
          workgroup

	- Server: This needs to run before anything else. It handles commands from main, passes commands onto the slave, then handles calls from the slave to the plugin

	- Master: This is the main screen where you select the pages from. This will page will never change, and just instructs the slave to change page

	- Slave:  Displays the pages selected from master, then sends the commands to the plugin

	- Plugin: This must sit on the same PC as that is running XPlane. This listens to commands from slave, and then calls the functions within the C plugin. Commands will come into EventHandler.DataHandler and from there can call the C plugin.

* `IOSees_Xplane`

	- This is the C plugin
	
	- Can be tricky setting this project up depending on your environment. See [Xplane SDK](http://www.xsquawkbox.net/xpsdk/mediawiki/Main_Page) for help.
