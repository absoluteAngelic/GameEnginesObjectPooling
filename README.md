# GameEnginesObjectPooling

## This repo/project is an otherwise blank scene with primitives being spawned 50 times per second and moving in a random direction, then dying/despawning after 1.7 seconds.

-We'll only be looking at the "PlayerLoop", as in, we'll ignore the editor's performance, and the performance of the profiler itself <br>

-We ignore the last couple hundred frames from each test, as the mouse going over the Unity window to press the Stop button causes spikes <br>

-Both tests were done with the exact same files in the project to avoid potential bias (non-object pooling was profiled AFTER it was implemented, but with a spawner that doesn't use pooling. The only difference in code is the Die() method of the BlueEnemy either destroying it completely, or releasing it back into the pool instead)

### BEFORE OBJECT POOLING:

The peak CPU-time frame I could find was 1.41ms, which, sustained, is ~709fps. Hovered around 1.2-1.3ms.
<img width="1084" height="612" alt="image" src="https://github.com/user-attachments/assets/f32c6658-6ec1-49b0-be42-f1588873640a" />

Rendering peaked at 466 draw calls in a frame<br>
<img width="450" height="61" alt="image" src="https://github.com/user-attachments/assets/e8444a16-a820-45e3-8e0e-69313672d5c1" />

3.83GB of total committed memory
<img width="1074" height="419" alt="image" src="https://github.com/user-attachments/assets/873d500b-7dde-4b62-8ebd-c0eaa277fe0c" />

### AFTER OBJECT POOLING:

The peak CPU-time frame I could find was 1.58ms, which, sustained, is ~632fps. Hovered around 1.1-1.2ms.
<img width="1090" height="610" alt="image" src="https://github.com/user-attachments/assets/51d51e8d-7f66-4a66-8d78-7f569e953293" />

Rendering peaked at 440 draw calls in a frame<br>
<img width="454" height="64" alt="image" src="https://github.com/user-attachments/assets/b2d67df7-4013-4524-83a9-59e0822f094c" />

3.92GB of total committed memory
<img width="1073" height="419" alt="image" src="https://github.com/user-attachments/assets/be30c789-c9c3-48bc-b540-5b6d6ff34b9a" />

With object pooling, funnily enough, there was actually a ~12% increase of slowest CPU-time frame, and a ~2% increase of memory usage. Perhaps I tested in a weird way or had too many enemies or something else, but I couldn't find a performance benefit of using object pooling. It did prevent constant small garbage collection, however, the constant garbage collection seemed to have next to zero negative performance impact.
