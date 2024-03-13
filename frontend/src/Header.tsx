import logo from "./BowlingCrewimg.png";

function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <br />
        <h4 className="text-center text-white">
          Here's some information about the amazing bowlers in our database!
        </h4>
      </div>
    </header>
  );
}

export default Header;
