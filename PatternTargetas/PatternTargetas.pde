int col; // Variable númerica que me entregara el random de morados.
int r;

color [] colModulos = new color[3]; // array de color que almacena mis 3 tonos morados
int [] rotar = new int [4];

float anchBloque = 100;
float altoBloque = 100;

float cant;
void setup() {

  //size(148, 232);  
  //size(940, 1360);
  size(500,500);
  // mis 3 tonos morados 
  colModulos[0] = color(80, 38, 111);
  colModulos[1] = color(102, 49, 137);
  colModulos[2] = color(111, 66, 147);

  rotar[0] = 0;
  rotar[1] = 90;
  rotar[2] = 180;
  rotar[3] = 270;

  noStroke();
  rectMode(CENTER);
}

void draw() {

  background(255);

  for (int i = 0; i < 7; i++) {
    for (int j = 0; j < 10; j++) {
      cant = random(0, 3);
      modMorados(i*100, j*100+altoBloque/10, anchBloque, altoBloque);
    }
  }
//pat1(width/2, height/2, 100, 100);
  noLoop();
}

void modMorados(float posX, float posY, float tamX, float tamY) {

  int select = int(cant);

  if (select == 0) {
    pat1(posX, posY, tamX, tamY);
  } else if (select == 1) {
    pat2(posX, posY, tamX, tamY);
  } else if (select == 2) {
    pat3(posX, posY, tamX, tamY);
  }
}

void pat1(float posX, float posY, float tamX, float tamY) {
  r= (rotar[(int)random(0, 4)]);
  pushMatrix();
  translate(posX, posY);
  rotate(radians(r));

  noStroke();
  col = color(colModulos[(int)random(0, 3)]);
  fill(col);
  rect(0, 0, tamX, tamY);

  col = color(colModulos[(int)random(0, 3)]); 
  fill(col);
  ellipse(0, 0, tamX/2, tamY/2);


  fill(255, random(20, 40));
  triangle(0-tamX/2, 0+tamY/2, 0+tamX/2, 0+tamY/2, 0+tamX/2, 0-tamY/2);
  popMatrix();
}

void pat2 (float posX, float posY, float tamX, float tamY) {
  color same =col = color(colModulos[(int)random(0, 3)]); 

  r= (rotar[(int)random(0, 4)]);
  pushMatrix();
  translate(posX, posY);
  rotate(radians(r));

  fill(same);
  stroke(same);
  strokeWeight(2);
  triangle(0, 0, 0-tamX/2, 0-tamY/2, 0+tamX/2, 0-tamY/2);
  triangle(0, 0, 0-tamX/2, 0+tamY/2, 0+tamX/2, 0+tamY/2);

  col = color(colModulos[(int)random(0, 3)]); 
  fill(col);
  stroke(col);
  triangle(0, 0, 0-tamX/2, 0-tamY/2, 0-tamX/2, 0+tamY/2);
  triangle(0, 0, 0+tamX/2, 0+tamY/2, 0+tamX/2, 0-tamY/2);

  fill(same);
  ellipse(0+tamX/3, 0, tamX/4, tamY/4);
  ellipse(0-tamX/3, 0, tamX/4, tamY/4);

  fill(255, random(0, 40));
  noStroke();
  rect(0, 0, tamX, tamY);

  popMatrix();
}

void pat3 (float posX, float posY, float tamX, float tamY) {
  r= (rotar[(int)random(0, 4)]);

  pushMatrix();
  translate(posX, posY);
  rotate(radians(r));

  col = color(colModulos[(int)random(0, 3)]); 
  fill(col);
  noStroke();
  rect(0, 0, tamX, tamY);

  col = color(colModulos[(int)random(0, 3)]); 
  fill(col);
  ellipse(0-tamX/4, 0+tamY/4, tamX/4, tamY/4);
  ellipse(0+tamX/4, 0+tamY/4, tamX/4, tamY/4);
  ellipse(0+tamX/4, 0-tamY/4, tamX/4, tamY/4);
  ellipse(0-tamX/4, 0-tamY/4, tamX/4, tamY/4);

  fill(255, random(10, 40));
  triangle(0-tamX/2, 0+tamY/2, 0+tamX/2, 0+tamY/2, 0+tamX/2, 0-tamY/2);
  popMatrix();
}

void keyPressed() {
  if ( key == 'a' ) {           
    redraw();
  } else if (key== 'r') {
    saveFrame("captura_###.png"); //PNG es recomendado, pero se puede cambiar la extension a .jpg
  }

  if (key=='1') { // Morado
    colModulos[0] = color(80, 38, 111);
    colModulos[1] = color(102, 49, 137);
    colModulos[2] = color(111, 66, 147);
  } else if (key == '2') { // Violeta
    colModulos[0] = color(144, 58, 142);
    colModulos[1] = color(150, 77, 152);
    colModulos[2] = color(168, 118, 177);
  } else if (key == '3') { // Azul
    colModulos[0] = color(50, 58, 143);
    colModulos[1] = color(63, 71, 151);
    colModulos[2] = color(77, 97, 170);
  } else if (key == '4') { // Celeste
    colModulos[0] = color(63, 129, 195);
    colModulos[1] = color(89, 162, 217);
    colModulos[2] = color(113, 195, 238);
  } else if (key == '5') { // Amarillo
    colModulos[0] = color(250, 191, 15);
    colModulos[1] = color(251, 207, 75);
    colModulos[2] = color(253, 223, 135);
  } else if (key == '6') { // Naranjo
    colModulos[0] = color(234, 98, 49);
    colModulos[1] = color(239, 129, 88);
    colModulos[2] = color(243, 157, 125);
  }
}
