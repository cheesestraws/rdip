# rdip

rdip is a project to do two things:

* To stream control signals from a PI RailDriver controller over an IP network to another computer where the rail simulator is running.  You could even do this over the Internet, if you really like latency for some reason.
* To let people experiment with writing software to control a rail simulator that has RailDriver support by just sending UDP packets and not having to learn a specialist interface.

There are a number of things in this repository, which may be useful separately or together.  rdip was originally designed for the train simulator in the Human Factors Research Group at the University of Nottingham.

## RDShark

RDShark (with apologies to Wireshark) is a train simulator simulator: you can put it in your plugins folder with RailDriver.dll and run it instead of Rail Simulator to get a list of the requests that are coming in from the RailDriver.dll client.  Requests to set rail simulator values are just dumped to the screen; requests to get a rail simulator value are also dumped but responed to with a demo value.  You can also simulate locomotive changes either with or without combined throttle and brake.

Note: if you want to scroll up and down in the list, turn off Follow new requests in the View menu.  If you want to copy a list item to the clipboard, use Edit -> Copy.

## rdip-server

This is a tool which listens on a UDP port, receives control signals, and pushes those signals into the rail simulator.  Each UDP packet consists of a Name=Value pair.  The Name should be taken from the list of control names in RailDriver.cs.  The value is a float, as a string.  Most controls this goes from 0.0 to 1.0.  Buttons are 0 or 1.  Examples of valid packets:

* `Throttle=0.7`
* `LocomotiveBrake=0.3`
* `Horn=1`

By default, rdip-server listens on UDP port 3333.  There is as yet no UI to change this.

## TinyUDP

This is a very simple tool which just fires off UDP packets.  It's for testing/debugging rdip-server with

## RD-Demos

These are demos for how to drive RailDriver.dll.  They are companion pieces to blog posts in which I wrote about RailDriver.dll, thus:

* http://www.jamesjoycewaskorean.com/post.php?post=20150401211620
* http://www.jamesjoycewaskorean.com/post.php?post=20150402185416