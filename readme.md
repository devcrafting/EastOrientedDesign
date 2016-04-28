# East Oriented approach

It could be seen as a design or programming tool. See [James Ladd blog post](http://jamesladdcode.com/?p=12) for reference.

We could also say that it is "well applied" OOP, considering that OOP is about message passing as its root (and not about getters/setters with services/managers manipulating them). It also recalls the [Tell Don't Ask principle](http://martinfowler.com/bliki/TellDontAsk.html).

I tried it at [Software Craftsmanship Lyon Coding Dojo in april 2016](http://www.meetup.com/fr-FR/Software-Craftsmanship-Lyon/events/230319693/). Here is a result.

## Note of this implementation

I applied TDD and emergent design. I never tried to add something I did not need.

I started focused on first rule of East Oriented : do not return anything else than "this" or nothing/void. It led me to introduce IOutput interface on first test.

This way, I ended basic FizzBuzz with a "big" if/else...then I added the Bang case (for 7), but with my implementation, it would become a "ifs" nightmare :).
Then I introduced the IAnalyzer and refactored existing implementation before I add Bang. 
I also added a private inner class OutputWriter which encapsulates message passing from an analyzer to IOutput. This class manage the default case where no analyzer matches the input.

I stopped here, since I don't see more reasons to refactor more.