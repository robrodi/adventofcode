original source: [https://adventofcode.com/2020/day/8](https://adventofcode.com/2020/day/8)
## --- Day 8: Handheld Halting ---
Your flight to the major airline hub reaches cruising altitude without incident.  While you consider checking the in-flight menu for one of those drinks that come with a little umbrella, you are interrupted by the kid sitting next to you.

Their [handheld game console](https://en.wikipedia.org/wiki/Handheld_game_console) won't turn on! They ask if you can take a look.

You narrow the problem down to a strange <em>infinite loop</em> in the boot code (your puzzle input) of the device. You should be able to fix it, but first you need to be able to run the code in isolation.

The boot code is represented as a text file with one <em>instruction</em> per line of text. Each instruction consists of an <em>operation</em> (<code>acc</code>, <code>jmp</code>, or <code>nop</code>) and an <em>argument</em> (a signed number like <code>+4</code> or <code>-20</code>).


 - <code>acc</code> increases or decreases a single global value called the <em>accumulator</em> by the value given in the argument. For example, <code>acc +7</code> would increase the accumulator by 7. The accumulator starts at <code>0</code>. After an <code>acc</code> instruction, the instruction immediately below it is executed next.
 - <code>jmp</code> <em>jumps</em> to a new instruction relative to itself. The next instruction to execute is found using the argument as an <em>offset</em> from the <code>jmp</code> instruction; for example, <code>jmp +2</code> would skip the next instruction, <code>jmp +1</code> would continue to the instruction immediately below it, and <code>jmp -20</code> would cause the instruction 20 lines above to be executed next.
 - <code>nop</code> stands for <em>No OPeration</em> - it does nothing.  The instruction immediately below it is executed next.

For example, consider the following program:

<pre>
<code>nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6
</code>
</pre>

These instructions are visited in this order:

<pre>
<code>nop +0  | 1
acc +1  | 2, 8(!)
jmp +4  | 3
acc +3  | 6
jmp -3  | 7
acc -99 |
acc +1  | 4
jmp -4  | 5
acc +6  |
</code>
</pre>

First, the <code>nop +0</code> does nothing. Then, the accumulator is increased from 0 to 1 (<code>acc +1</code>) and <code>jmp +4</code> sets the next instruction to the other <code>acc +1</code> near the bottom. After it increases the accumulator from 1 to 2, <code>jmp -4</code> executes, setting the next instruction to the only <code>acc +3</code>. It sets the accumulator to 5, and <code>jmp -3</code> causes the program to continue back at the first <code>acc +1</code>.

This is an <em>infinite loop</em>: with this sequence of jumps, the program will run forever. The moment the program tries to run any instruction a second time, you know it will never terminate.

Immediately <em>before</em> the program would run an instruction a second time, the value in the accumulator is <em><code>5</code></em>.

Run your copy of the boot code. Immediately before any instruction is executed a second time, <em>what value is in the accumulator?</em>


