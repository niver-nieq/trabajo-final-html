@charset "UTF-8";
@import '~node_modules/modern-normalize/modern-normalize.css';
.container-main {
  display: flex;
  justify-content: center;
}

.container {
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 1200px;
  background-color: white;
}

.container__photo {
  display: flex;
  justify-content: center;
  width: 968px;
  background-color: white;
  margin-top: 20px;
}

.photo {
  margin-right: 10px;
}

.photo:hover {
  opacity: 0.3;
  -webkit-transform: rotate(360deg);
  transform: rotate(360deg);
  border-radius: 50%;
  -webkit-border-radius: 50%;
  box-shadow: 0px 0px 15px 15px #ec731e;
  -webkit-box-shadow: 0px 0px 15px 15px #ec731e;
  transform: rotate(360deg);
  -webkit-transform: rotate(360deg);
}

.container__commet {
  font-family: DM sans;
  font-weight: 500;
  font-size: 20px;
  display: flex;
  width: 968px;
  padding: 47px 109px 39px 109px;
  margin-top: 16px;
  background-color: rgb(250, 250, 250);
}

.container__commet:hover {
  text-decoration: underline;
  text-decoration-color: rgb(225, 225, 225);
}

.comilla {
  background: url(../images/“comillas.svg) no-repeat;
  width: 90px;
}

.container__name {
  font-family: DM sans;
  font-weight: 500;
  font-size: 20px;
  display: flex;
}

.container__name:hover {
  color: rgb(211, 19, 66);
}

.elipse {
  margin-top: 20px;
  padding-right: 10px;
}

/*sass src/sass/index.scss src/css/index.css*/

/*# sourceMappingURL=index.cs.map */
