# Learning Journal

## 9/2/21

I wanted to open Visual Studio from Unity. But it wouldn't let me do it without a script file. So I created a new script file, and used it to open Visual Studio.

I added a speed variable, but it didn't change the result. I think I forgot to multiply my movement by my speed. That was correct.

The behaviour works as expected up to the 90 degrees point. And then it starts to misbehave. The up and down movement when we reach the 90 degree point starts to wobble. Maybe we are not resetting our look at direction after we move. Maybe we are rotating in the wrong space. This fixes the horizontal problem, but not the vertical.

We want to preserve our orientation as we go over the top.