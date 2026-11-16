# GameEnginesObjectPooling

## This repo/project is an otherwise blank scene with primitives being spawned 50 times per second and moving in a random direction, then dying/despawning after 1.7 seconds.

### BEFORE OBJECT POOLING:

There are many visible large spikes of CPU usage
<img width="1116" height="374" alt="image" src="https://github.com/user-attachments/assets/fce76e71-3976-4956-ab6e-349c2750801a" />

On one frame, the CPU alone took 19.13ms (which, if sustained, is less than 60fps, which is absolutely insane for a blank scene with only a bunch of primitives being spawned and moving around)
<img width="1110" height="598" alt="image" src="https://github.com/user-attachments/assets/27e080ee-7613-408e-81d9-687d756ea23f" />

There are two things interesting to note.

1 - The GPU isn't struggling in any way whatsoever, and literally takes less than 0.01ms to render each frame, which is BLAZINGLY fast (if this was the only thing we had to wait for, we could run at more than 100,000fps) <br>
<img width="457" height="62" alt="image" src="https://github.com/user-attachments/assets/3fdd7a79-d117-44a7-8729-528361d466f3" />

2 - On these horribly long frames from the CPU, Unity's garbage collector takes up the vast majority of the CPU time (for the 19.13ms frame, more than **83%** of that time was taken by the garbage collector. If we ignore the time the garbage collector took for this frame, the cpu would have taken ~3.25ms, which if sustained, is ~307fps, at the *slowest* point in time)
<img width="1110" height="145" alt="image" src="https://github.com/user-attachments/assets/99264871-9226-4aab-a403-0c67c1e341db" />
