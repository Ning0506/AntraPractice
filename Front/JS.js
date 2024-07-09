// Question 1

let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

let sum = 0;

for (let key in salaries) {
    sum += salaries[key];
}

console.log(sum);

// Question 2
function multiplyNumeric(obj) {
  for (let key in obj) {
      if (typeof obj[key] === 'number') {
          obj[key] *= 2;
      }
  }
}

// Question 3
function checkEmailId(str) {
  str = str.toLowerCase();
  let atPos = str.indexOf('@');
  let dotPos = str.indexOf('.', atPos);
  
  return (atPos !== -1 && dotPos !== -1 && dotPos > atPos + 1);
}

// Question 4
function truncate(str, maxlength) {
  if (str.length > maxlength) {
      return str.slice(0, maxlength - 1) + '…';
  } else {
      return str;
  }
}

// Question 5
// 1. Create an array styles with items "James" and "Brennie"
let styles = ["James", "Brennie"];

// 2. Append "Robert" to the end
styles.push("Robert");

// 3. Replace the value in the middle by "Calvin"
let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin";

// 4. Remove the first value of the array and show it
let firstElement = styles.shift();
console.log(firstElement); // "James"

// 5. Prepend "Rose" and "Regal" to the array
styles.unshift("Rose", "Regal");
