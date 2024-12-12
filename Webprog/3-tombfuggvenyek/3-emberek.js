const people = [
    { name: "Dani", age: 47 },
    { name: "Kata", age: 31 },
    { name: "Laci", age: 18 },
    { name: "Béla", age: 62 },
    { name: "Anikó", age: 24 },
    { name: "Gábor", age: 39 },
    { name: "Eszter", age: 28 },
    { name: "János", age: 52 },
    { name: "József", age: 24 },
    { name: "Tibor", age: 38 },
    { name: "Réka", age: 24 },
    { name: "Ákos", age: 29 }
];


//1
const huszevalatti = people.find(e => e.age<20);
console.log("1",huszevalatti.name);

//2
const negyvenalatti = people.filter(e => e.age<40).length;
console.log("2",negyvenalatti);

//3
const hatnalnagyobb = people.some(e => e.name.length>6);
console.log("3",hatnalnagyobb);

//4
const novekvo = people.toSorted((a, b) => a.age - b.age); // !!! 2023 !!!
console.log("4",novekvo);
//5
const atlagelet = people.reduce((s,e) => s+e.age,0)/people.length;
console.log("5",atlagelet.toFixed(2));

//6
const idos = people.filter(e => e.age>atlagelet);
console.log(idos.name);

//7
const utolsoj = people.findLast(e=>e.name[0] === "J" );
console.log("7",utolsoj);

//8
const legidosebb = people.reduce((s, e) => e.age > s ? e.age : s, 0);
console.log("8",legidosebb);

//9
const ugyanaz = people.filter((e,i));
const ugyanaz2 = people.filter((e, i) => people.some(???));
console.log("9",ugyanaz2);
//10
const s = "a";
const as = people.find((e,s) => s === e.name);
const as2 = people.filter(e => e.name  === as);
console.log("10",as2);
