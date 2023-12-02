original source: [https://adventofcode.com/2020/day/3](https://adventofcode.com/2020/day/3)
## --- Day 3: Toboggan Trajectory ---
With the toboggan login problems resolved, you set off toward the airport. While travel by toboggan might be easy, it's certainly not safe: there's very minimal steering and the area is covered in trees. You'll need to see which angles will take you near the fewest trees.

Due to the local geology, trees in this area only grow on exact integer coordinates in a grid. You make a map (your puzzle input) of the open squares (<code>.</code>) and trees (<code>#</code>) you can see. For example:

<pre>
<code>..##.......
#...#...#..
.#....#..#.
..#.#...#.#
.#...##..#.
..#.##.....
.#.#.#....#
.#........#
#.##...#...
#...##....#
.#..#...#.#
</code>
</pre>

These aren't the only trees, though; due to something you read about once involving arboreal genetics and biome stability, the same pattern repeats to the right many times:

<pre>
<code><em>..##.......</em>..##.........##.........##.........##.........##.......  --->
<em>#...#...#..</em>#...#...#..#...#...#..#...#...#..#...#...#..#...#...#..
<em>.#....#..#.</em>.#....#..#..#....#..#..#....#..#..#....#..#..#....#..#.
<em>..#.#...#.#</em>..#.#...#.#..#.#...#.#..#.#...#.#..#.#...#.#..#.#...#.#
<em>.#...##..#.</em>.#...##..#..#...##..#..#...##..#..#...##..#..#...##..#.
<em>..#.##.....</em>..#.##.......#.##.......#.##.......#.##.......#.##.....  --->
<em>.#.#.#....#</em>.#.#.#....#.#.#.#....#.#.#.#....#.#.#.#....#.#.#.#....#
<em>.#........#</em>.#........#.#........#.#........#.#........#.#........#
<em>#.##...#...</em>#.##...#...#.##...#...#.##...#...#.##...#...#.##...#...
<em>#...##....#</em>#...##....##...##....##...##....##...##....##...##....#
<em>.#..#...#.#</em>.#..#...#.#.#..#...#.#.#..#...#.#.#..#...#.#.#..#...#.#  --->
</code>
</pre>

You start on the open square (<code>.</code>) in the top-left corner and need to reach the bottom (below the bottom-most row on your map).

The toboggan can only follow a few specific slopes (you opted for a cheaper model that prefers rational numbers); start by <em>counting all the trees</em> you would encounter for the slope <em>right 3, down 1</em>:

From your starting position at the top-left, check the position that is right 3 and down 1. Then, check the position that is right 3 and down 1 from there, and so on until you go past the bottom of the map.

The locations you'd check in the above example are marked here with <code><em>O</em></code> where there was an open square and <code><em>X</em></code> where there was a tree:

<pre>
<code>..##.........##.........##.........##.........##.........##.......  --->
#..<em>O</em>#...#..#...#...#..#...#...#..#...#...#..#...#...#..#...#...#..
.#....<em>X</em>..#..#....#..#..#....#..#..#....#..#..#....#..#..#....#..#.
..#.#...#<em>O</em>#..#.#...#.#..#.#...#.#..#.#...#.#..#.#...#.#..#.#...#.#
.#...##..#..<em>X</em>...##..#..#...##..#..#...##..#..#...##..#..#...##..#.
..#.##.......#.<em>X</em>#.......#.##.......#.##.......#.##.......#.##.....  --->
.#.#.#....#.#.#.#.<em>O</em>..#.#.#.#....#.#.#.#....#.#.#.#....#.#.#.#....#
.#........#.#........<em>X</em>.#........#.#........#.#........#.#........#
#.##...#...#.##...#...#.<em>X</em>#...#...#.##...#...#.##...#...#.##...#...
#...##....##...##....##...#<em>X</em>....##...##....##...##....##...##....#
.#..#...#.#.#..#...#.#.#..#...<em>X</em>.#.#..#...#.#.#..#...#.#.#..#...#.#  --->
</code>
</pre>

In this example, traversing the map using this slope would cause you to encounter <code><em>7</em></code> trees.

Starting at the top-left corner of your map and following a slope of right 3 and down 1, <em>how many trees would you encounter?</em>


