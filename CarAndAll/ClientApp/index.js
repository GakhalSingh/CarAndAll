import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route, Switch, Link } from 'react-router-dom';

const Home = () => (
    <div>
        <h2>Home Pagina</h2>
        <p>Welkom op de homepagina!</p>
    </div>
);

const About = () => (
    <div>
        <h2>Over</h2>
        <p>Dit is een informatiepagina over deze app.</p>
    </div>
);

const App = () => (
    <Router>
        <div className="container">
            <nav>
                <Link to="/" className="btn btn-primary m-1">Home</Link>
                <Link to="/about" className="btn btn-secondary m-1">Over</Link>
            </nav>
            <Switch>
                <Route exact path="/" component={Home} />
                <Route path="/about" component={About} />
            </Switch>
        </div>
    </Router>
);

ReactDOM.render(<App />, document.getElementById('root'));
