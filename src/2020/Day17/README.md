original source: [https://adventofcode.com/2020/day/17](https://adventofcode.com/2020/day/17)
## --- Day 17: Conway Cubes ---
As your flight slowly drifts through the sky, the Elves at the Mythical Information Bureau at the North Pole contact you. They'd like some help debugging a malfunctioning experimental energy source aboard one of their super-secret imaging satellites.

The experimental energy source is based on cutting-edge technology: a set of Conway Cubes contained in a pocket dimension! When you hear it's having problems, you can't help but agree to take a look.

The pocket dimension contains an infinite 3-dimensional grid. At every integer 3-dimensional coordinate (<code>x,y,z</code>), there exists a single cube which is either <em>active</em> or <em>inactive</em>.

In the initial state of the pocket dimension, almost all cubes start <em>inactive</em>. The only exception to this is a small flat region of cubes (your puzzle input); the cubes in this region start in the specified <em>active</em> (<code>#</code>) or <em>inactive</em> (<code>.</code>) state.

The energy source then proceeds to boot up by executing six <em>cycles</em>.

Each cube only ever considers its <em>neighbors</em>: any of the 26 other cubes where any of their coordinates differ by at most <code>1</code>. For example, given the cube at <code>x=1,y=2,z=3</code>, its neighbors include the cube at <code>x=2,y=2,z=2</code>, the cube at <code>x=0,y=2,z=3</code>, and so on.

During a cycle, <em>all</em> cubes <em>simultaneously</em> change their state according to the following rules:


 - If a cube is <em>active</em> and <em>exactly <code>2</code> or <code>3</code></em> of its neighbors are also active, the cube remains <em>active</em>. Otherwise, the cube becomes <em>inactive</em>.
 - If a cube is <em>inactive</em> but <em>exactly <code>3</code></em> of its neighbors are active, the cube becomes <em>active</em>. Otherwise, the cube remains <em>inactive</em>.

The engineers responsible for this experimental energy source would like you to simulate the pocket dimension and determine what the configuration of cubes should be at the end of the six-cycle boot process.

For example, consider the following initial state:

<pre>
<code>.#.
..#
###
</code>
</pre>

Even though the pocket dimension is 3-dimensional, this initial state represents a small 2-dimensional slice of it. (In particular, this initial state defines a 3x3x1 region of the 3-dimensional space.)

Simulating a few cycles from this initial state produces the following configurations, where the result of each cycle is shown layer-by-layer at each given <code>z</code> coordinate (and the frame of view follows the active cells in each cycle):

<pre>
<code>Before any cycles:

z=0
.#.
..#
###


After 1 cycle:

z=-1
#..
..#
.#.

z=0
#.#
.##
.#.

z=1
#..
..#
.#.


After 2 cycles:

z=-2
.....
.....
..#..
.....
.....

z=-1
..#..
.#..#
....#
.#...
.....

z=0
##...
##...
#....
....#
.###.

z=1
..#..
.#..#
....#
.#...
.....

z=2
.....
.....
..#..
.....
.....


After 3 cycles:

z=-2
.......
.......
..##...
..###..
.......
.......
.......

z=-1
..#....
...#...
#......
.....##
.#...#.
..#.#..
...#...

z=0
...#...
.......
#......
.......
.....##
.##.#..
...#...

z=1
..#....
...#...
#......
.....##
.#...#.
..#.#..
...#...

z=2
.......
.......
..##...
..###..
.......
.......
.......
</code>
</pre>

After the full six-cycle boot process completes, <em><code>112</code></em> cubes are left in the <em>active</em> state.

Starting with your given initial configuration, simulate six cycles. <em>How many cubes are left in the active state after the sixth cycle?</em>


