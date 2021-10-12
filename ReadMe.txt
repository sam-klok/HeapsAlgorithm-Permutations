Heap's algorithm generates all possible permutations of n objects.
Let's do it for integers.

Collection:    1, 2, 3
Permutations: {1, 2, 3}
              {1, 3, 2}
              {2, 1, 3}
              {2, 3, 1}
              {3, 1, 2}
              {3, 2, 1}


Theoretical explanation:
https://en.wikipedia.org/wiki/Heap%27s_algorithm

Practical explanations:
https://stackoverflow.com/questions/11208446/generating-permutations-of-a-set-most-efficiently

Good example for char objects:
https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer

thank you,
Sam Klok


======================================
Sometimes we need to do "Alternating parity permutations". So even permutate with even, odd with odd.
See attached images with details about this task, and solition is in method GetPerAlternateParity.