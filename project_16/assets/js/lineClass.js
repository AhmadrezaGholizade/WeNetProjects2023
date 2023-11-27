

// Defining a Class for Lines.
class Line {
    constructor(x1, y1, x2, y2) {
      this.start = { x: x1, y: y1 };
      this.end = { x: x2, y: y2 };
    }
    calculateDistance() {
      const deltaX = this.end.x - this.start.x;
      const deltaY = this.end.y - this.start.y;
      return Math.sqrt(deltaX ** 2 + deltaY ** 2).toFixed(4); // Round the distance to 4 decimal places
    }
}

// function for press button
function Calculate_dis(event) {
  // Prevent the default form submission behavior
  //  causing a page reload or a navigation to a new page
  event.preventDefault();

  const formData = new FormData(event.target);
  const X1 = formData.get('X1');
  const Y1 = formData.get('Y1');
  const X2 = formData.get('X2');
  const Y2 = formData.get('Y2');

  const line = new Line(X1, Y1, X2, Y2);
  const distance = line.calculateDistance();
  
  
  // place to show result
  const disElement = document.getElementById('dis');
  disElement.style.display = "block";
  disElement.innerHTML = 'Distance between points: ' + distance;
}