## Form1
- controller: Control
- box: Box
- csv: CSV
- button3Numberofproducts3: int
- button1Numberofproducts1: int

+ Form1()
+ button2_Click(sender: object, e: EventArgs): void
+ button3_Click(sender: object, e: EventArgs): void
+ button4_Click(sender: object, e: EventArgs): void
+ button5_Click(sender: object, e: EventArgs): void
+ button6_Click(sender: object, e: EventArgs): void
+ button8_Click(sender: object, e: EventArgs): void
+ summit_Click(sender: object, e: EventArgs): void

## Control
- product1: int
- product2: int
- product3: int
- product4: int
- product5: int

+ mybox3(): bool

## Box
- box1: Image
- box2: Image
- box3: Image
- box4: Image
- box5: Image
- sum: int
- products: int

## CSV
+ FileCsv(lists: string, products: int, sum: int): bool

Form1 -- Control
Form1 -- Box
Form1 -- CSV
