original source: [https://adventofcode.com/2020/day/14](https://adventofcode.com/2020/day/14)
## --- Day 14: Docking Data ---
As your ferry approaches the sea port, the captain asks for your help again. The computer system that runs this port isn't compatible with the docking program on the ferry, so the docking parameters aren't being correctly initialized in the docking program's memory.

After a brief inspection, you discover that the sea port's computer system uses a strange [bitmask](https://en.wikipedia.org/wiki/Mask_(computing)) system in its initialization program. Although you don't have the correct decoder chip handy, you can emulate it in software!

The initialization program (your puzzle input) can either update the bitmask or write a value to memory.  Values and memory addresses are both 36-bit unsigned integers.  For example, ignoring bitmasks for a moment, a line like <code>mem[8] = 11</code> would write the value <code>11</code> to memory address <code>8</code>.

The bitmask is always given as a string of 36 bits, written with the most significant bit (representing <code>2^35</code>) on the left and the least significant bit (<code>2^0</code>, that is, the <code>1</code>s bit) on the right. The current bitmask is applied to values immediately before they are written to memory: a <code>0</code> or <code>1</code> overwrites the corresponding bit in the value, while an <code>X</code> leaves the bit in the value unchanged.

For example, consider the following program:

<pre>
<code>mask = XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
mem[8] = 11
mem[7] = 101
mem[8] = 0
</code>
</pre>

This program starts by specifying a bitmask (<code>mask = ....</code>). The mask it specifies will overwrite two bits in every written value: the <code>2</code>s bit is overwritten with <code>0</code>, and the <code>64</code>s bit is overwritten with <code>1</code>.

The program then attempts to write the value <code>11</code> to memory address <code>8</code>. By expanding everything out to individual bits, the mask is applied as follows:

<pre>
<code>value:  000000000000000000000000000000001011  (decimal 11)
mask:   XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
result: 00000000000000000000000000000<em>1</em>0010<em>0</em>1  (decimal 73)
</code>
</pre>

So, because of the mask, the value <code>73</code> is written to memory address <code>8</code> instead. Then, the program tries to write <code>101</code> to address <code>7</code>:

<pre>
<code>value:  000000000000000000000000000001100101  (decimal 101)
mask:   XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
result: 00000000000000000000000000000<em>1</em>1001<em>0</em>1  (decimal 101)
</code>
</pre>

This time, the mask has no effect, as the bits it overwrote were already the values the mask tried to set. Finally, the program tries to write <code>0</code> to address <code>8</code>:

<pre>
<code>value:  000000000000000000000000000000000000  (decimal 0)
mask:   XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
result: 00000000000000000000000000000<em>1</em>0000<em>0</em>0  (decimal 64)
</code>
</pre>

<code>64</code> is written to address <code>8</code> instead, overwriting the value that was there previously.

To initialize your ferry's docking program, you need the sum of all values left in memory after the initialization program completes. (The entire 36-bit address space begins initialized to the value <code>0</code> at every address.) In the above example, only two values in memory are not zero - <code>101</code> (at address <code>7</code>) and <code>64</code> (at address <code>8</code>) - producing a sum of <em><code>165</code></em>.

Execute the initialization program. <em>What is the sum of all values left in memory after it completes?</em> (Do not truncate the sum to 36 bits.)


