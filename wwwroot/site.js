// KitchenEquip — site.js

document.addEventListener('DOMContentLoaded', () => {
    // 1. Smooth scroll to anchor (seu código original mantido)
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                e.preventDefault();
                target.scrollIntoView({ behavior: 'smooth', block: 'start' });
            }
        });
    });

    // 2. AJAX para Filtros, Busca e Paginação
    const catalogContainer = document.getElementById('catalog-results');

    if (catalogContainer) {
        // Interceptar envio do formulário de busca
        const searchForm = document.querySelector('.hero-search-form');
        if (searchForm) {
            searchForm.addEventListener('submit', async function (e) {
                e.preventDefault(); // Impede o recarregamento da página
                const url = new URL(this.action);
                url.searchParams.set('search', this.querySelector('input[name="search"]').value);
                url.searchParams.set('page', '1'); // Nova busca sempre volta para a página 1
                await updateCatalog(url.toString());
            });
        }

        // Interceptar cliques nas categorias, botão "limpar" e paginação
        document.addEventListener('click', async function (e) {
            const link = e.target.closest('.filter-pill, .filter-clear-link, .page-link');
            if (link && link.tagName === 'A') {
                e.preventDefault(); // Impede o recarregamento da página
                await updateCatalog(link.href);

                // Opcional: Rola a tela suavemente até o topo dos produtos ao trocar de página
                if (link.classList.contains('page-link')) {
                    catalogContainer.scrollIntoView({ behavior: 'smooth', block: 'start' });
                }
            }
        });

        // Função que busca os novos dados e atualiza a tela
        async function updateCatalog(url) {
            // Efeito de "carregando" (deixa os produtos meio transparentes)
            catalogContainer.style.opacity = '0.5';
            catalogContainer.style.pointerEvents = 'none';

            try {
                const response = await fetch(url);
                const htmlText = await response.text();

                // Cria um documento virtual e recorta apenas a div #catalog-results
                const parser = new DOMParser();
                const doc = parser.parseFromString(htmlText, 'text/html');
                const newCatalog = doc.getElementById('catalog-results');

                if (newCatalog) {
                    catalogContainer.innerHTML = newCatalog.innerHTML;
                    // Atualiza a barra de endereço para o usuário poder copiar o link ou usar o botão "Voltar" do navegador
                    window.history.pushState({}, '', url);
                }
            } catch (error) {
                console.error('Erro ao atualizar o catálogo:', error);
            } finally {
                // Tira o efeito de carregando
                catalogContainer.style.opacity = '1';
                catalogContainer.style.pointerEvents = 'auto';
            }
        }

        // Faz o botão "Voltar" do navegador funcionar perfeitamente com o AJAX
        window.addEventListener('popstate', async () => {
            await updateCatalog(window.location.href);
        });
    }
});

