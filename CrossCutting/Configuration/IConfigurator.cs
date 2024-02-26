namespace DavidTielke.PersonManagerApp.CrossCutting.Configuration;

// OCP - Open Closed Principle
// ISP - Interface Segregation Principle

// --> oo
// + Analysierbar
// - Erweiterbarkeit
// +/- Austauschbarkeit
// - Testbarkeit
// + Stabilität

// --> oo
// +/- Analysierbarkeit
// +/- Erweiterbarkeit
// +/- Austauschbarkeit
// +/- Testbarkeit
// + Stabilität

// --> const
// - Analysierbarkeit
// + Erweiterbarkeit
// +/- Austauschbarkeit
// + Testbarkeit
// - Stabilität

// --> const
// + Analysierbarkeit
// + Erweiterbarkeit
// + Austauschbarkeit
// + Testbarkeit
// + Stabilität
public interface IConfigurator
{
    public TValue Get<TValue>(string key);
    public void Set<TValue>(string key, TValue value);
}